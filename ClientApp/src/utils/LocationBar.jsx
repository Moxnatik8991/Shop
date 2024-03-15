import React from 'react';
import { NavLink, useLocation } from "react-router-dom";


const LocationBar = ()=>{
    let location =useLocation() // Получаем текущий путь
    let splitChar = "/"
    let locationSplitArray = location.pathname.split(splitChar)  // Сплит в массив по символу
    let path = ""
    return (
        <div>
            { locationSplitArray.map (
                (item, itemIndex)=>{
                    path === ""                         
                        ? path = "/"
                        : path === "/"
                            ? path = path + item
                            : path = path + "/" + item;
                    return (
                        <span key={item}>
                                    { " " }
                            <NavLink onClick={ 
                                (e)=>{
                                itemIndex === locationSplitArray.length - 1 && e.preventDefault ()
                                }
                            } 
                                     to={ path }
                            >
                                { itemIndex === 0 ? "/" : item }
                            
                            </NavLink>
                            
                            { itemIndex === locationSplitArray.length - 1 ? null : " > " }
                        
                        </span>
                    )
                }
            )
            }
        </div>
    );
};

export default LocationBar;