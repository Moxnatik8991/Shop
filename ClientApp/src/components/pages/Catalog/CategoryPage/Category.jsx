import React, { useEffect, useState } from 'react';
import './Category.css'
import { NavLink , useNavigate , useOutletContext , useParams } from "react-router-dom";
import LocationBar from "../../../../utils/LocationBar";
import axios from "axios";
import Item from "../Item/Item";
let initCat = [
    {
        name: "Ноутбуки и компьютеры",
        categoryId: null,
        categories: [{
            name: "Планшеты",
            categoryId: "580e4680-fd28-48b8-b976-22f23c61a9cb",
            categories: null,
                id: "41a8bad2-7360-4b1f-9d64-148580a1a510",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            },
            {
                name: "Ноутбуки",
                categoryId: "580e4680-fd28-48b8-b976-22f23c61a9cb",
                categories: null,
                id: "5ce876a7-20cb-4b48-bb35-56bd3d77b529",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            },
            {
                name: "Мониторы",
                categoryId: "580e4680-fd28-48b8-b976-22f23c61a9cb",
                categories: null,
                id: "861f5ba9-edb2-4d3b-a943-70e748f201ee",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            },
            {
                name: "Компьютерные комплектующие",
                categoryId: "580e4680-fd28-48b8-b976-22f23c61a9cb",
                categories: [{
                    name: "Видеокарты",
                    categoryId: "acd402ca-a6d4-4676-a82d-b723671049cc",
                    categories: null,
                        id: "3b286d62-d045-48a1-890f-1352a2fd28c0",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "Процессоры",
                        categoryId: "acd402ca-a6d4-4676-a82d-b723671049cc",
                        categories: null,
                        id: "777c3b7d-7701-4956-a0ba-6f3774bd9afe",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "Материнские платы",
                        categoryId: "acd402ca-a6d4-4676-a82d-b723671049cc",
                        categories: null,
                        id: "7a5bffd1-5a21-4317-a409-b2c007e3027c",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "Оперативная память",
                        categoryId: "acd402ca-a6d4-4676-a82d-b723671049cc",
                        categories: null,
                        id: "452c43d2-9c51-4180-873d-c3382bbf8600",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "Звуковые карты",
                        categoryId: "acd402ca-a6d4-4676-a82d-b723671049cc",
                        categories: null,
                        id: "941cd916-5318-420b-96ea-cc87bd852501",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "Жесткие диски",
                        categoryId: "acd402ca-a6d4-4676-a82d-b723671049cc",
                        categories: null,
                        id: "698f95fb-4ee0-40ec-af69-db879f45f771",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    }
                ],
                id: "acd402ca-a6d4-4676-a82d-b723671049cc",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            },
            {
                name: "Компьютеры",
                categoryId: "580e4680-fd28-48b8-b976-22f23c61a9cb",
                categories: null,
                id: "fe272257-138e-4ef7-9eb5-c870f766cad4",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            }
        ],
        id: "580e4680-fd28-48b8-b976-22f23c61a9cb",
        dataCreate: "2024-03-03T11:16:26.0128826",
        dataUpdate: "2024-03-07T11:16:26.0128826"
    },
    {
        name: "Смартфоны, ТВ и Электроника",
        categoryId: null,
        categories: [
            {
                name: "Носимые гаджеты",
                categoryId: "f6f334d4-4ee3-4194-9aca-546dbef39f46",
                categories: [
                    {
                        name: "Фитнес-браслеты",
                        categoryId: "fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd",
                        categories: null,
                        id: "216c988c-c095-4f1e-b3c2-0baf5933c42e",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "Смарт-кольца",
                        categoryId: "fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd",
                        categories: null,
                        id: "39107a2b-5d47-48b6-b803-a1c28c9c486a",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "Смарт-часы",
                        categoryId: "fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd",
                        categories: null,
                        id: "b85e139d-f167-43bc-ba6e-c5e9d9efe384",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    },
                    {
                        name: "3D и VR очки",
                        categoryId: "fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd",
                        categories: null,
                        id: "2d988ac2-746e-49f0-812c-ef1016dec01c",
                        dataCreate: "2024-03-03T11:16:26.0128826",
                        dataUpdate: "2024-03-07T11:16:26.0128826"
                    }
                ],
                id: "fd4f896d-fd54-4f01-8b5f-1aa90c4c5ebd",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            },
            {
                name: "Наушники и аксессуары",
                categoryId: "f6f334d4-4ee3-4194-9aca-546dbef39f46",
                categories: null,
                id: "178323ff-3bd7-4951-b563-84798aa01f4b",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            },
            {
                name: "Телевизоры",
                categoryId: "f6f334d4-4ee3-4194-9aca-546dbef39f46",
                categories: null,
                id: "d190b221-9b1a-4e26-8dd8-98d0d2d01414",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            },
            {
                name: "Мобильные телефоны",
                categoryId: "f6f334d4-4ee3-4194-9aca-546dbef39f46",
                categories: null,
                id: "2ccc3123-e24f-4ac1-ad53-cfc6c7639794",
                dataCreate: "2024-03-03T11:16:26.0128826",
                dataUpdate: "2024-03-07T11:16:26.0128826"
            }
        ],
        id: "f6f334d4-4ee3-4194-9aca-546dbef39f46",
        dataCreate: "2024-03-03T11:16:26.0128826",
        dataUpdate: "2024-03-07T11:16:26.0128826"
    },
    {
        name: "string",
        categoryId: null,
        categories: null,
        id: "f1f27db0-a97f-446e-84a7-f0e7da5151d8",
        dataCreate: "2024-03-17T17:43:38.5504469",
        dataUpdate: "2024-03-17T17:43:38.5504516"
    }
]

const Category = ()=>{
    console.log("re")
    
    const[isLoading,setIsLoading]=useState(false)
    let nav = useNavigate();

    let storage = useOutletContext().categories
    let params = useOutletContext().params;
    
    const[ currentCategory,setCurrentCategory] = useState({})
    const[ categoryItem, setCategoryItem]=useState([])

    const [asd,setAsd]=useState([])
   
    
    useEffect ( ()=>{
        setIsLoading(true)
        let string = Object.values(params)[Object.values(params).length-1];
        axios.get(`https://5iaf6t.realhost-free.net/api/Category/Get/${string}`)
            .then(response=>{
                let testUrl= encodeURIComponent(`[{"id": "categoryId", "value": "${response.data.result.id}"}]`)
                axios.get(`https://5iaf6t.realhost-free.net/api/Product/GetWithFilteringAndPagination?ColumnFilters=${ testUrl }`)
                    .then(response2 =>{
                        setCurrentCategory(response.data.result);
                        setCategoryItem(response2.data.result)
                        setIsLoading(false)
                    })
                
            })
        
        if(Object.keys(params).length>0)
        {
            let testA=storage;
            let categoriesNaId = Object.values(params).map((param)=>{
               
               
                let filterByParam = (arr)=>{
                   let a = arr.filter(el=>el.id===param)
                     if(a.length>0)
                        {
                            testA = a[0].categories
                            return {name:a[0].name, id: a[0].id}
                        }
                }
               return filterByParam(testA);
            })
            
            setAsd(categoriesNaId)
        }
        return ()=>{
            setAsd([])
        }
        
    }, [params] );
    
    return (
        <>
            {
            <div className="category-container">

                {  <LocationBar arr={ asd }/>}

                { currentCategory.name && <div className="category-name">{ currentCategory.name }</div> }

                <div className="advertisment">
                    <img
                        src="https://www.pro-of.com.ua/wp-content/uploads/2018/02/ab35c5ac5b7d2dda5ddc48c01e4efa15.jpg"
                        alt="No image..."/>
                </div>


                <div className="subCatBlock">
                    { currentCategory.categories && currentCategory.categories.map ( el=><NavLink 
                        to={ el.id }>
                        <img width={"50px"} border={"5px solid black"} style={{justifySelf:"center"}} src="https://cdn.pixabay.com/photo/2021/10/11/23/49/app-6702045_640.png" alt="No image..."/>
                        <div style={{justifySelf:"center"}}>{ el.name }</div>
                        
                    </NavLink> ) }
                </div>

                { categoryItem && categoryItem.length > 0 && 
                    <>
                        <div className="just-line"></div>
                    <div className="category-items-block">
                        <div className="category-items-filtres">
                            <h3>Filtres</h3>
                            <div>filter2</div>
                            <div>filter3</div>
                        </div>
                        <div style={{border:"2px solid grey",borderRadius:"10px",backgroundColor:"grey", margin:"10px 0"}}>
                            
                        </div>
                        <div className="category-items-list">
                            {categoryItem.map(el=><Item test={asd} element={el}  id={el.id} name={ el.name } description={ el.description }
                                                        price={ el.price }/>)}
                        </div>
                    </div>
                    </>
                }

            </div>
            }
        </>);
};

export default Category;