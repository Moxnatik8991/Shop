import React from 'react';
import st from './Category.module.scss'
import { useNavigate } from "react-router-dom";

const Category = ({name,id,file})=>{
    const navigate = useNavigate()
    return (
        <div className={st.container} onClick={()=>{navigate(`/catalog/${id}`)}}>
            <img src={file?file.path:"https://cdn.pixabay.com/photo/2021/10/11/23/49/app-6702045_640.png"} alt=""/>
            <div>{name}</div>
        </div>
    );
};

export default Category;