import { useParams } from "react-router-dom";
import { useEffect , useState } from "react";
import { useSelector } from "react-redux";
import axios from "axios";


const getItemById= async (itemId)=>{
    let result = (await axios.get( `http://5iaf6t.realhost-free.net/api/Product/Get/${ itemId }` )).data.result
    return result
}
const getItemsByCategory= async (catId)=>{
    let testUrl= encodeURIComponent(`[{"id": "categoryId", "value": "${catId}"}]`);
    let result = (await axios.get(`http://5iaf6t.realhost-free.net/api/Product/GetWithFilteringAndPagination?ColumnFilters=${ testUrl }`)).data.result
    return result
}
const testGetPathAdnCat=(arr,id)=>{
    let path=[]
    let find=false
    let cat;
    const finder=(arr,id)=>{
       
        if(find===false){
            arr.find(el=>{
              
                if(el.id===id){
                    
                    path.push({id:el.id,name:el.name})
                    find=true
                    cat=el;
                }
                if(el.categories && find===false){
                    path.push({id:el.id,name:el.name})
                    finder(el.categories,id)
                }
                if(!el.categories){
                    return
                }
                if(find===false && path.length>0){
                    path.pop()
                }
            })
        }
    }
    finder(arr,id);
    return {
        path,
        cat
    }
}
    

const itemCase=(itemId,allCat,sI,sC,sP)=>{
    
   let item = getItemById(itemId);
   item.then(response=>{
        let res= testGetPathAdnCat(allCat,response.categoryId)
       sI(response)
       sC(res.cat)
       sP(res.path)
   })
    
}
const categoryCase=(IdCategory,allCat,sC,sP,sI)=>{
    let res = testGetPathAdnCat(allCat,IdCategory)
    let items=getItemsByCategory(res.cat.id)
        items.then(response=>{
            sI(response)
            sC(res.cat);
            sP(res.path);
        })
    
}
const useGetData = ()=>{
   
    const {itemId,IdCategory} = useParams();
    const {categories} = useSelector(state=>state.item)
    
    const [currentCategory,setCurrentCategory]=useState()
    const [currentItem,setCurrentItem]=useState()
    const [currentPath,setCurrentPath]=useState()
    const [items,setItems]=useState()
    
    
    
    useEffect ( ()=>{
        
        if(itemId){
            itemCase(itemId,categories,setCurrentItem,setCurrentCategory,setCurrentPath)
        }
        if(IdCategory){
            categoryCase(IdCategory,categories,setCurrentCategory,setCurrentPath,setItems)
        }
        
    } , [itemId,IdCategory] );
    
return {currentCategory,currentItem,currentPath,items}
};

export default useGetData;