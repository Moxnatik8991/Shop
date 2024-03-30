import { useParams } from "react-router-dom";
import { useEffect , useState } from "react";
import { useSelector } from "react-redux";

const findCurrentCategory=(id,all,setCurrentPath)=>{
    let result;
    const finder = (id,all)=>{
        if(!result) {
            all.find ( el=>{
                if (el.id === id) {
                    result = el
                } else if (el.categories) finder ( id , el.categories )
            } )
        }
    } 
    finder(id,all)
    return result;
}
const useGetCategory = ()=>{
    const {itemId,IdCategory} = useParams();
    const {categories} = useSelector(state=>state.item)
    
    const [currentCategory,setCurrentCategory]=useState()
    const [currentItem,setCurrentItem]=useState()
    const [currentPath,setCurrentPath]=useState()
    useEffect ( ()=>{
        if(IdCategory){
            setCurrentCategory(findCurrentCategory(IdCategory,categories,setCurrentPath))
        }
        if(itemId){
            
        }
        
    } , [itemId,IdCategory] );
return {currentCategory,currentItem}
};

export default useGetCategory;