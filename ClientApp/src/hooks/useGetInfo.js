import axios , { all } from "axios";
import { useParams } from "react-router-dom";
import { useSelector } from "react-redux";
import { useEffect , useState } from "react";


const doBoth=(allCategories,catId,itemId,setItems,setLoad,setItem)=>{

    let curCat;
    let curPath=[];
    


    const findCurrentCategory=(allCategories,cur)=>{
        if(!allCategories)return null
        allCategories.find(element=>{
            if(element.id===cur){curCat=element;curPath.push({id:element.id,name:element.name})}
            else if (element.categories)return findCurrentCategory(element.categories,cur)
        } )
    }
    const getPath=(id,allCategories)=>{

        if(!id) return null
        if(!allCategories)return null
        let test=[];
        let sub=id;
      

        let finder=(par1=sub,par2=allCategories)=>{
                par2.find(el=>{
                    
                    if(sub) {
                        if (el.id === par1) {
                            curPath.push ( { id : el.id , name : el.name } )
                            if (el.categoryId) {
                                sub = el.categoryId;
                                finder ( sub )
                            }
                            if (!el.categoryId) sub = null
                        } else if (el.categories) return finder ( sub , el.categories )
                    }
                })
            
        }
        finder();
        return test;

    }
    if(itemId){
        axios.get( `https://5iaf6t.realhost-free.net/api/Product/Get/${itemId}`)
            .then(response=>{
                setItem(response.data.result)
                getPath(response.data.result.categoryId,allCategories)
            })
    }
    if(!curCat)findCurrentCategory(allCategories,catId);
    if(curCat){
        getPath(curCat.categoryId,allCategories);
        let testUrl= encodeURIComponent(`[{"id": "categoryId", "value": "${curCat.id}"}]`);
        setLoad(true)
        axios.get(`https://5iaf6t.realhost-free.net/api/Product/GetWithFilteringAndPagination?ColumnFilters=${ testUrl }`)
            .then(response=>{setItems(response.data.result);setLoad(false)})
    }

    return [curPath,curCat];

}
export const UseGetInfo=()=>{
    
    const {category,itemId} = useParams()

    const allCategories = useSelector(state=>state.item.categories)
    const[currentCategory,setCurrentCategory]=useState()
    const[currentPath,setCurrentPath]=useState();
    const[items,setItems]=useState();
    const [load,setLoad]=useState(false)
    
    const [item,setItem]=useState()

    useEffect ( ()=>{
        let arr = doBoth(allCategories,category,itemId,setItems,setLoad,setItem);
        setCurrentPath(arr[0]);
        setCurrentCategory(arr[1])
    } , [category] );
    useEffect ( ()=>{
        let arr = doBoth(allCategories,category,itemId,setItems,setLoad,setItem);
        setCurrentPath(arr[0]);
        setCurrentCategory(arr[1])
    } , [itemId] );
    return {category:category, currentCategory:currentCategory,currentPath:currentPath,items:items,load:load,item:item }
}