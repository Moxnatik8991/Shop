import React, { useEffect, useState } from "react";
import "./Catalog.css"
import Item from "./Item/Item";
import { NavLink, Outlet, Route, Routes, useOutlet, useOutletContext, useParams } from "react-router-dom";
import axios from "axios";

let kategories = [
    {path:"golden", name:"Golden Eggs"},
    {path:"infinity", name:"Infinity Eggs"},
    {path:"forest", name:"Forest Eggs"},
    {path:"sea", name:"Sea Eggs"},
    {path:"caves", name:"Caves Eggs"},
];
let items = [
    {name: "Infinity Dragon Agg1",inStoke: true, category:"infinity", image: "https://static.vecteezy.com/system/resources/previews/023/961/425/original/3d-dragon-egg-free-png.png"},
    {name: "Golden Dragon Agg1",inStoke: false, category:"golden", image: "https://static.vecteezy.com/system/resources/previews/014/967/648/non_2x/golden-metallic-dragon-egg-png.png"},
    {name: "Forest Dragon Agg1",inStoke: true, category:"forest", image: "https://static.vecteezy.com/system/resources/previews/014/967/658/original/silver-metallic-dragon-egg-png.png"},
    {name: "Sea Dragon Agg1",inStoke: false, category:"sea", image: "https://static.vecteezy.com/system/resources/previews/014/967/532/original/copper-metallic-dragon-egg-png.png"},
    {name: "Caves Dragon Agg1",inStoke: true, category:"caves", image: "https://static.vecteezy.com/system/resources/previews/014/058/832/original/dragon-egg-design-illustration-isolated-on-transparent-background-free-png.png"},
    {name: "Infinity Dragon Agg2",inStoke: true, category:"infinity", image: "https://static.vecteezy.com/system/resources/previews/023/961/425/original/3d-dragon-egg-free-png.png"},
    {name: "Golden Dragon Agg2",inStoke: false, category:"golden", image: "https://static.vecteezy.com/system/resources/previews/014/967/648/non_2x/golden-metallic-dragon-egg-png.png"},
    {name: "Forest Dragon Agg2",inStoke: true, category:"forest", image: "https://static.vecteezy.com/system/resources/previews/014/967/658/original/silver-metallic-dragon-egg-png.png"},
    {name: "Sea Dragon Agg2",inStoke: false, category:"sea", image: "https://static.vecteezy.com/system/resources/previews/014/967/532/original/copper-metallic-dragon-egg-png.png"},
    {name: "Caves Dragon Agg2",inStoke: true, category:"caves", image: "https://static.vecteezy.com/system/resources/previews/014/058/832/original/dragon-egg-design-illustration-isolated-on-transparent-background-free-png.png"},
    {name: "Infinity Dragon Agg3",inStoke: true, category:"infinity", image: "https://static.vecteezy.com/system/resources/previews/023/961/425/original/3d-dragon-egg-free-png.png"},
    {name: "Golden Dragon Agg3",inStoke: false, category:"golden", image: "https://static.vecteezy.com/system/resources/previews/014/967/648/non_2x/golden-metallic-dragon-egg-png.png"},
    {name: "Forest Dragon Agg3",inStoke: true, category:"forest", image: "https://static.vecteezy.com/system/resources/previews/014/967/658/original/silver-metallic-dragon-egg-png.png"},
    {name: "Sea Dragon Agg3",inStoke: false, category:"sea", image: "https://static.vecteezy.com/system/resources/previews/014/967/532/original/copper-metallic-dragon-egg-png.png"},
    {name: "Caves Dragon Agg3",inStoke: true, category:"caves", image: "https://static.vecteezy.com/system/resources/previews/014/058/832/original/dragon-egg-design-illustration-isolated-on-transparent-background-free-png.png"},
    ];


export let CategoryFilter = () => {
    
    let param = useOutletContext();
    
    return (
        <>
            {
                items.filter ( i => i.category === param )
                    .map ( el => <Item name={ el.name } inStock={ el.inStoke } image={ el.image }/> )
            }

        </>
    )
}

const Catalog = () => {
    const [itemss, setItems] = useState (null)
    let a = useParams();
    useEffect ( ()=>{
        axios.get("https://5iaf6t.realhost-free.net/api/Product/GetAll")
            .then(responce=>setItems(responce.data.result))
    }, [] );
    
    if(!itemss)
        return (
            <div> none </div>
        )

    return (
        <>
            <div className={ "cover-back" }>
                <div className="catalog">
                    <div>
                        <h5>Available Categories:</h5>
                        <div className={ "catalog-categories" }>
                            { kategories.map ( el=><NavLink to={ el.path }>{ el.name }</NavLink> ) }
                        </div>
                    </div>
                    <div className="catalog-content">
                        { a.category ? <Outlet context={ a.category }/>
                            : items.map ( el=><Item name={ el.name } inStock={ el.inStoke } image={ el.image }/> )

                        }
                    </div>
                </div>
            </div>
        </>
    )
}
export default Catalog;