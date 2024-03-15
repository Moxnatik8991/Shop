import React, { useEffect, useState } from 'react';
import './Category.css'
import { NavLink, useLocation, useNavigate, useOutletContext, useParams } from "react-router-dom";
import LocationBar from "../../../../utils/LocationBar";

const Category = ()=>{
    const [test1,setTest1]= useState([])
    let test = useParams();
    let a = useOutletContext()
    let newArr= a.filter(i=>i.name===test.category)
    debugger
    
    return (
        <>
            
            <div className="category-container">
                <LocationBar />
                <div className="category-name">{ test.category }</div>
                <div className="advertisment"><img src="https://www.pro-of.com.ua/wp-content/uploads/2018/02/ab35c5ac5b7d2dda5ddc48c01e4efa15.jpg" alt=""/></div>
                <div style={{display:"grid",gridTemplateColumns:"repeat(4, 3fr)"}}>
                    <div>
                        <NavLink to={"/catalog/Category4/25"}> asdad</NavLink>
                        <div>image</div>
                        <div>name</div>
                        <div>sub categories?</div>
                    </div>
                    <div>
                        <div>image</div>
                        <div>name</div>
                        <div>sub categories?</div>
                    </div>
                </div>
            </div>
        </>);
};

export default Category;