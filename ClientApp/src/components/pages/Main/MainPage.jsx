import React , { useEffect , useState } from 'react';
import { ApiItems } from "../../../https";
import Item from "../Categories/Item/Item";
import DropDown from "./DropDown";
import { Pagination } from "@mui/material";
import { usePagination } from "../../../hooks/usePagination";




const MainPage = ()=>{
    const [items , setItems] = useState ( null )
    const [selected,setSelected]=useState({
        name:'От дешевых к дорогим',
        value: 'price',
        desc: false
    })
    const {page,setPagination,paginationEl}=usePagination();
    

    useEffect ( ()=>{
        if(!selected){ApiItems.getAll ().then ( res=>setItems ( res ) )}
        if(selected){let obj = {id:selected.value,desc:selected.desc}
            ApiItems.getWithFilter(obj,page).then(
                res=>{
                    setItems(res.data.result)
                    setPagination(JSON.parse(res.headers.pagination))
                    
                }
            )}
    } , [selected,page] );
   
    return (<div style={{width:"90%",margin:"0 auto"}}>
            <div style={{width:"200px"}}>
                <DropDown selected={selected} setSelected={setSelected}/>
            </div>
            
            <div style={ { display : "grid" , gridTemplateColumns : "repeat(3, 1fr)" } }>
                { items && items.map ( el=><Item key={ el.id } name={ el.name } id={ el.id } price={ el.price }/> ) }
            </div>
            {paginationEl}
        </div>

    );
};

export default MainPage;