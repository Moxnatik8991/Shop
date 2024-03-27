import React , { useEffect , useState } from 'react';
import { Popper } from '@mui/base/Popper';
import st from './Home.module.scss'
import { useDispatch , useSelector } from "react-redux";
import { useActions } from "../hooks/useActions";
import { getAllCategories , getAllItems } from "../redux/items.action";


const Home = ()=>{
    const dispatch = useDispatch();
    
    let {items, isLoading,categories} = useSelector(state=>state.item)
    let {doSomething} = useActions();
    let a = [{name:"first"}]
    useEffect ( ()=>{
        dispatch(getAllItems())
        dispatch(getAllCategories())
    } , [] );
    let test = ()=>{
        
        dispatch(getAllItems())
       
    }
    console.log("render")
    console.log(categories)
    
    return (
        <div>
            
            <button onClick={test}>get</button>
            {isLoading
                ?<div>Loading...</div>
                :items.map(el=><div key={el.id}>{el.name}</div>)}
            
        </div>
    );
};


export const Modal = ({id,open,anchorEl})=>{
    let {items, isLoading,categories} = useSelector(state=>state.item)
    const[hovering,setHovering]=useState()
    let sub = null;
    let mouseEnter=(el)=>{
        if(el.categories?.length>0){
            setHovering(el.categories.map(elem=><div>{elem.name}</div>))
        }
    }
    
    return (
        <>
            <Popper id={id} open={open} anchorEl={anchorEl}>
                <div className={st.testModal}>
                    <div>{categories && categories.map ( el=>{ return <div style={ { border : "none",width:"max-content"} }
                                                                  onMouseEnter={()=> {mouseEnter(el)} }>{ el.name }</div> }) }
                        
                    </div>
                    
                    <div className={st.secondPlace}>{ hovering && hovering }</div>
                </div>
            </Popper>  
        </>
    )
}

export default Home;