import React , { useEffect , useState } from 'react';
import { ApiItems } from "../../../https";
import Item from "../Categories/Item/Item";
import st from './TestPage.module.scss'
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import { str } from "ajv";



export const DropDown=({selected,setSelected})=>{
    const [isOpened,setIsOpened]=useState(false)
   
    const array = ['От дешевых к дорогим','От дорогих к дешевым'];
    const ar = [
        {
            name:'От дешевых к дорогим',
            value: 'price',
            desc: false
        },
        {
            name:'От дорогих к дешевым',
            value: 'price',
            desc: true
        },
        {
            name:'По просмотрам',
            value: 'countViews',
            desc: true
        },
        {
            name:'по рейтингу',
            value: 'rating',
            desc: true
        }
    ]
    return(
        <div className={st.container}>
            <div className={st.select} onClick={()=>{setIsOpened(prevState=>!prevState)}}>
                <div style={{textAlign:"center"}}>
                    {selected?selected.name:"chose one"}
                </div>
                <div style={{display:"flex",placeItems:"center"}} 
                     >
                    <ExpandMoreIcon fontSize="small"/>
                </div>
                
            </div>
            { isOpened && 
                <div className={ st.optionsContainer }>
                    {
                        ar.map ( el=><button disabled={selected?.name===el.name} key={el.name} onClick={ ()=>{
                            setSelected ( el )
                            setIsOpened(false)
                        } } className={ st.option }>{ el.name }</button> )
                    }
                </div>
            }

        </div>
    )
}


const TestPage = ()=>{
    const [items , setItems] = useState ( null )
    const [selected,setSelected]=useState(null)
    
    useEffect ( ()=>{
        if(!selected){ApiItems.getAll ().then ( res=>setItems ( res ) )}
        if(selected){let obj = {id:selected.value,desc:selected.desc}
        ApiItems.getWithFilter(obj).then(res=>{setItems(res)})}
    } , [selected] );
   
    
    return (<div style={{width:"90%",margin:"0 auto"}}>
            <div style={{width:"150px"}}>
                <DropDown selected={selected} setSelected={setSelected}/>
            </div>
            <div style={ { display : "grid" , gridTemplateColumns : "repeat(3, 1fr)" } }>
                { items && items.map ( el=><Item key={ el.id } name={ el.name } id={ el.id } price={ el.price }/> ) }
            </div>
        </div>

    );
};

export default TestPage;