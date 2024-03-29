import React , { useEffect , useState } from 'react';
import { Popper } from '@mui/base/Popper';
import st from './Home.module.scss'
import { useDispatch , useSelector } from "react-redux";
import { useActions } from "../hooks/useActions";
import { getAllCategories , getAllItems } from "../redux/items.action";
import { NavLink } from "react-router-dom";

const testArray=[
    {id:1,sub:[
            {id:11,sub:null},
            {id:12,sub:null},
            {id:13,sub:null},
        ]},
    {id:2,sub:null},
    {id:3,sub:[
            {id:31,sub:null},
            {id:32,sub:null},
            {id:33,sub:null},
        ]},
    {id:4,sub:[
            {id:41,sub:null},
            {id:42,sub:[
                    {id:421,sub:null},
                    {id:422,sub:null},
                ]}
        ]},
    {id:5,sub:null},
]
const Home = ()=>{
    let result;
    
   const finder=(array,element)=>{
       debugger
       
           result = array.find(el=>el.id===element)
           if(!result) {
               array.map(el=>{
                   if(el.sub && !result){
                       finder(el.sub,element)
                   }
                   return result
               })
               
           }
          
   }
    
     finder(testArray,422);
   debugger 
    return (
        <div>
            {result?.id}
        </div>
    );
};

export default Home;