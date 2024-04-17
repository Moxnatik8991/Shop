import React , { useState } from 'react';
import st from './AdminComments.module.scss'
import Review from "../Item/Comments/Review/Review";
let testObj ={
    commentsForApprove:[
        {
            id:	'apr1',
            dataCreate:	'2024-04-17T11:06:02.976Z', 
            dataUpdate:	'2024-04-17T11:06:02.976Z', 
            firstName:	'approve', 
            rating:	4, 
            text:	'comment1', 
            productId:	'3fa85f64-5717-4562-b3fc-2c963f66afa6', 
        },
        {
            id:	'apr2',
            dataCreate:	'2024-04-17T11:06:02.976Z',
            dataUpdate:	'2024-04-17T11:06:02.976Z',
            firstName:	'approve',
            rating:	0,
            text:	'comment2',
            productId:	'3fa85f64-5717-4562-b3fc-2c963f66afa6',
        },
        {
            id:	'apr3',
            dataCreate:	'2024-04-17T11:06:02.976Z',
            dataUpdate:	'2024-04-17T11:06:02.976Z',
            firstName:	'approve',
            rating:	0,
            text:	'comment3',
            productId:	'3fa85f64-5717-4562-b3fc-2c963f66afa6',
        }
    ],
    allowedComments:[
        {
            id:	'allow1',
            dataCreate:	'2024-04-17T11:06:02.976Z',
            dataUpdate:	'2024-04-17T11:06:02.976Z',
            firstName:	'allow',
            rating:	0,
            text:	'comment1',
            productId:	'3fa85f64-5717-4562-b3fc-2c963f66afa6',
        },
        {
            id:	'allow2',
            dataCreate:	'2024-04-17T11:06:02.976Z',
            dataUpdate:	'2024-04-17T11:06:02.976Z',
            firstName:	'allow',
            rating:	0,
            text:	'comment2',
            productId:	'3fa85f64-5717-4562-b3fc-2c963f66afa6',
        },
        {
            id:	'allow3',
            dataCreate:	'2024-04-17T11:06:02.976Z',
            dataUpdate:	'2024-04-17T11:06:02.976Z',
            firstName:	'allow',
            rating:	0,
            text:	'comment3',
            productId:	'3fa85f64-5717-4562-b3fc-2c963f66afa6',
        }
    ]
} 
const AdminComments = ()=>{
    const [id,setId]=useState(null)
    const [comments,setComments]=useState(null)
    const [list,setList]=useState(null)
    const getComments=()=>{
        setComments(testObj)
    }
    const handleAction=(action,element)=>{
        switch (action) {
            case 'approve':
                //post request on Add + delete request on forApprove
                debugger
                return
            case 'edit':
                debugger
                return
            case 'delete':
                if(list.name === 'commentsForApprove'){
                    debugger
                    //delete request on forApprove
                }
                if(list.name === 'allowedComments'){
                    debugger
                    //delete request on allowed
                }
                return
        }
    }
    return (
        <div className={st.container}>
            <div className={ st.find }>
                <h4>Find comments by item id</h4>
                <div>
                    <span>Item id: </span>
                    <input onBlur={(e)=>{setId(e.currentTarget.value)}} 
                           type="text" 
                           placeholder='Write item id here...'/>

                </div>
                <button onClick={getComments}>Find</button>
                { comments && <div className={ st.choose }>
                    {Object.keys(comments).map(el=><span onClick={()=>{setList({name:el,list:comments[el]})}}>{el}</span>)}
                    
                </div> }

            </div>
            <div>
                { list &&
                    <div className={st.commentList}>
                        {list.list.map(el=>
                            <div className={st.comment}>
                                <Review key={ el.id }
                                        rating={ el.rating }
                                        firstName={ el.firstName }
                                        dataCreate={ el.dataCreate }
                                        text={ el.text }/>
                                <div className={st.actions}>
                                    { list.name !== 'allowedComments' && 
                                        <button onClick={()=>{handleAction('approve',el)}}>approve</button> 
                                    }
                                    <button onClick={()=>{handleAction('edit',el)}}>edit</button>
                                    <button onClick={()=>{handleAction('delete',el)}}>delete</button>
                                </div>
                            </div>
                           )}
                    </div>

                }
            </div>
        </div>
    );
};

export default AdminComments;