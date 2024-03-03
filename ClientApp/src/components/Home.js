import React, { useState } from 'react';
import axios from "axios";

const Home = ()=>{
    let[prices,setInput]=useState({input1: 1, input2: 999})
    let ChangePriceMin=(value)=>{
        setInput({...prices,input1 : parseInt(value)})
    }
    let ChangePriceMax=(value)=>{
        setInput({...prices,input2 : parseInt(value)})
    }
    
    let priceSortAr= encodeURIComponent(`[{"id": "price", "lowerValue": "${10}", "upperValue": "${12}"}]`)
    
    // let priseSortArToString ="["+ priceSortAr.map(li=>JSON.stringify(li,null,))+"]"
    // let newUrl = encodeURIComponent(priseSortArToString)
    let [users,setUsers]=useState(null)
    let getItems = async ()=>{
       let a = await axios.get("https://5iaf6t.realhost-free.net/api/Product/GetAll");
       setUsers(a.data.result);
    }
    let sortItems = async ()=>{
        let b = await axios.get(`https://5iaf6t.realhost-free.net/api/Product/GetWithFilteringAndPagination?ColumnFilters=${priceSortAr}`);
        setUsers(b.data.result);
    }
    let SearchByParams= async ()=>{
        let testUrl= encodeURIComponent(`[{"id": "price", "lowerValue": "${prices.input1}", "upperValue": "${prices.input2}"}]`)
        let responce = await axios.get(`https://5iaf6t.realhost-free.net/api/Product/GetWithFilteringAndPagination?PageSize=10&ColumnFilters=${testUrl}`);
        setUsers(responce.data.result);
    }
    
    return (
        <div>
            <div>
                <button onClick={ getItems }> get items</button>
                <button onClick={ sortItems }> sort Items</button>
                <input onBlur={(e)=>ChangePriceMin(e.target.value)} type="number"/>
                <input onBlur={(e)=>ChangePriceMax(e.target.value)} type="number"/>
                <button onClick={SearchByParams}>search by price params</button>
            </div>

            { users ? users.map ( user=>
                <div style={{margin:"10px",padding: "10px",borderRadius: "5px", border:"1px solid black", maxWidth: "150px"}}>
                    <div>Name: {user.name}</div>
                    <div>Description: { user.description}</div>
                    <div>Price: {user.price}</div>
                </div>
            ): null
            }
        </div>
    );
};

export default Home;