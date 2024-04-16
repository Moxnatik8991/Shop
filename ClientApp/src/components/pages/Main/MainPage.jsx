import React , { useEffect , useState } from 'react';
import { ApiItems } from "../../../https";
import Item from "../Categories/Item/Item";
import DropDown from "./DropDown";


const MainPage = ()=>{
    const [items , setItems] = useState ( null )
    const [selected,setSelected]=useState(null)

    useEffect ( ()=>{
        if(!selected){ApiItems.getAll ().then ( res=>setItems ( res ) )}
        if(selected){let obj = {id:selected.value,desc:selected.desc}
            ApiItems.getWithFilter(obj).then(res=>{setItems(res)})}
    } , [selected] );

    return (<div style={{width:"90%",margin:"0 auto"}}>
            <div style={{width:"200px"}}>
                <DropDown selected={selected} setSelected={setSelected}/>
            </div>
            <div style={ { display : "grid" , gridTemplateColumns : "repeat(3, 1fr)" } }>
                { items && items.map ( el=><Item key={ el.id } name={ el.name } id={ el.id } price={ el.price }/> ) }
            </div>
        </div>

    );
};

export default MainPage;