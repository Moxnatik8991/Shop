import React , { useState } from 'react';
import { useSelector } from "react-redux";
import { NavLink } from "react-router-dom";
import { Popper } from "@mui/base/Popper";
import st from "./CatalogModal.module.scss";

const CatalogModal = ({id,open,anchorEl,handleClick})=>{
    let {categories} = useSelector(state=>state.item)
    const[hovering,setHovering]=useState([])

    let mouseEnter=(el)=>{
        if(el.categories?.length>0){
            setHovering(el.categories.map(elem=>{
                let arr;
                if(elem.categories?.length>0){
                    arr = elem.categories.map(elema=>
                        <div key={elema.id}>
                            <NavLink   onClick={handleClick}  to={`/catalog/${elema.id}`}>{ elema.name }</NavLink>
                        </div>)
                }
                return <>
                    <div key={elem.id} style={{fontWeight:"bold"}}>
                        <NavLink  onClick={handleClick} to={`/catalog/${elem.id}`}>
                            { elem.name }
                        </NavLink></div>
                    {arr && arr.map(i=>i)}
                </>
            }))
        }
    }


    return (
        <>
            <Popper id={id} open={open} anchorEl={anchorEl}>
                <div className={st.testModal}>
                    <div className={st.firstPlace}>{categories && categories.map ( el=>{ 
                        return <div key={el.id} style={ { border : "none",width:"max-content"} }
                                    onMouseEnter={()=> {mouseEnter(el)} }>
                        <NavLink onClick={handleClick}   to={`/catalog/${el.id}`}>{ el.name }</NavLink>
                    </div> }) }

                    </div>

                    <div className={st.secondPlace}>{ hovering && hovering }</div>
                </div>
            </Popper>
        </>
    )
};

export default CatalogModal;