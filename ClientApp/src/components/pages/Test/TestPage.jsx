import React , { useEffect , useState } from 'react';
import { useDispatch } from "react-redux";
import { login } from "../../../redux/auth.aciton";
import axios from "axios";
import { $apiUsers } from "../../../https";

const testArr=[
    {id:1,name:"1",sub:[
        {id:11,name:"1_1",sub:null}
        ]
    },
    {id:2,name:"2",sub:[
            {id:21,name:"2_1",sub:null},
            {id:22,name:"2_2",sub:[
                {id:221,name:"2_2_1",sub:null},
                {id:222,name:"2_2_2",sub:null}
                ]
            },
        ]
    },
    {id:3,name:"3",sub:[
        {id:31,name:"3_1",sub:null}, 
            {id:32,name:"3_2",sub:null}]
    }
]
const testGetPath=(arr,id)=>{
    let path=[]
    let find=false
    let cat;
    const finder=(arr,id)=>{
        
        if(find===false){
            arr.find(el=>{
                
                if(el.id===id){
                    
                    path.push({name:el.name,id:el.id})
                    find=true
                    cat=el;
                }
                if(el.sub && find===false){
                    path.push({name:el.name,id:el.id})
                    finder(el.sub,id)
                }
                if(!el.sub){
                    return
                }
                if(find===false && path.length>0){
                    path.pop()
                }
            })
        }
    }
    finder(arr,id);
    return {
        path,
        cat
    }
}
const TestPage = ()=>{
    const [test,setTest]=useState('')
    const dispatch=useDispatch();
    const save = ()=>{
        dispatch(login({email:test,password:"123"}))
    }
    const users = ()=>{
        $apiUsers.get()
    }
    return (
        <div>
            <input type="text" value={test} onChange={(e)=>{setTest(e.currentTarget.value)}}/>
            <button onClick={save}> find new </button>
            <button onClick={users}>users</button>
        </div>
    );
};

export default TestPage;