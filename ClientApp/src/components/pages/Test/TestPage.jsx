import React , { useEffect , useState } from 'react';

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
    /*const [var1,setVar1]=useState(1)*/
    let var1 = 1;
    const [{path,cat},setObject]=useState({path:null,cat:null})

    useEffect ( ()=>{
        let testObj=testGetPath(testArr,var1)
          setObject(testObj)
    } , [var1] );
    console.log("render test")
    return (
        <div>
            {path && path.map(el=><div>{el.name}</div>)}
           {/* <button onClick={()=>{setVar1(32)}}> find</button>*/}
            <button onClick={()=>{var1=32}}> find new </button>
        </div>
    );
};

export default TestPage;