import React, { useEffect, useState } from 'react';
import './Category.css'
import { NavLink, useLocation, useNavigate, useOutletContext, useParams } from "react-router-dom";
import LocationBar from "../../../../utils/LocationBar";
import axios from "axios";

const Category = ()=>{
    const[ currentCategory,setCurrentCategory] = useState({})
    let params = useParams();
    const [allCategories,setAllCategories]=useState([])
    debugger
    
    
    
    
    useEffect (  ()=>{
        
        let yes  = async ()=> {
            let a = await axios.get ( "http://5iaf6t.realhost-free.net/api/Category/GetAll" )
            setAllCategories(a.data.result)
        if (Object.keys ( params ).length === 1) {
            let firstArr = a.data.result.filter ( i=>i.categories )
            let secondArr = firstArr.filter ( i=>i.id === params.category )
            debugger
            setCurrentCategory ( secondArr[0] );
        }
    }
    yes();
    }, [] );
    
   
    
    return (
        <>
            
            <div className="category-container">
                <LocationBar s={currentCategory.name} />
                { currentCategory.name && <div className="category-name">{currentCategory.name}</div> }

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