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
        }
    ]
    return(
        <div className={st.container}>
            <div className={st.select} onClick={()=>{setIsOpened(prevState=>!prevState)}}>
                <div>
                    {selected?selected.name:ar[0].name}
                </div>
                <div style={{display:"flex",placeItems:"center"}} 
                     >
                    <ExpandMoreIcon fontSize="small"/>
                </div>
                
            </div>
            { isOpened && 
                <div className={ st.optionsContainer }>
                    {
                        ar.map ( el=><div onClick={ ()=>{
                            setSelected ( el )
                            setIsOpened(false)
                        } } className={ st.option }>{ el.name }</div> )
                    }
                </div>
            }

        </div>
    )
}


const TestPage = ()=>{
    const [items , setItems] = useState ( null )
    const [selected,setSelected]=useState(null)
    const testObj = {id:"price",desc:true};
  
    useEffect ( ()=>{
        ApiItems.getAll ().then ( res=>setItems ( res ) )
    } , [] );
    const testF=(obj)=>{
        ApiItems.getWithFilter(obj).then(res=>{debugger})
    }

    return (<div style={{width:"90%",margin:"0 auto"}}>
            <div>
                <select>
                    <option value="1">1</option>
                    <option value="2">2</option>
                    <option value="3">3</option>
                </select>
            </div>
            <div style={{width:"250px"}}>
                <DropDown selected={selected} setSelected={setSelected}/>
            </div>
            
            <button onClick={()=>{testF(testObj)}}>filter</button>
            <div style={ { display : "grid" , gridTemplateColumns : "repeat(3, 1fr)" } }>
                { items && items.map ( el=><Item key={ el.id } name={ el.name } id={ el.id } price={ el.price }/> ) }
            </div>
        </div>

    );
};

export default TestPage;