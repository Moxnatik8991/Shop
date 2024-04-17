import React , { useEffect , useState } from 'react';
import st from './AdminCategories.module.scss';
import { ApiCategory } from "../../../https";
import KeyboardArrowDownIcon from '@mui/icons-material/KeyboardArrowDown';
import KeyboardArrowUpOutlinedIcon from '@mui/icons-material/KeyboardArrowUpOutlined';
import FormsPage from "./FormsPage";
const AdmCategories = ()=>{

    const [allCategories,setAllCategories]=useState(null)
    const [butIcon,setButIcon]=useState([])
    const [curCat,setCurCat]=useState()
    const [curAction,setCurAction]=useState(null)
    const [request,setRequest]=useState(false)
    const [isChosen,setIsChosen]=useState(false)
    

    useEffect ( ()=>{
        ApiCategory.getAll().then(response =>{setAllCategories(response)})
    } , [request] );
    const renderCat = (arr,hid)=>{
        return  arr.map(el=>{
            if(el.categories.length>0){
                return <div  hidden={hid}  className={st.item}>
                    <span  onClick={
                        (e)=>{
                            setCurCat(el);
                            setIsChosen(true)
                        }}>
                        {el.name}
                    </span>
                    <button onClick={(e)=>{hideShow(e,el.id)}}>
                        { butIcon.some(i=>i===el.id)?<KeyboardArrowUpOutlinedIcon/>:<KeyboardArrowDownIcon/>}
                    </button>
                    { renderCat ( el.categories,true ) } 
                </div>
            }
            else return <div hidden={hid} className={st.item} >
                <span onClick={()=>{
                    setCurCat(el);
                    setIsChosen(true)
                }}>
                    {el.name}
                </span>
            </div>
        })
    }
    let hideShow =(e,id)=>{
        setButIcon(prevState=>{
            if(prevState.some(el=>el===id))return prevState.filter(el=>el !== id)
            else return [...prevState,id]
        })
        let res = Array.from(e.currentTarget.parentElement.children);
        res.map(el=>{
            if(el.localName === 'div')el.hidden =!el.hidden;
        })

    }
    return (
        <div className={st.content}>
            <div className={ st.categories }>
                <div className={st.name}>All available Categories</div>
                <div className={st.items}>
                    {
                        allCategories && renderCat(allCategories,false)
                    }
                </div>
            </div>
            <div className={ st.formBl }>
                { isChosen && <div className={ st.navButtons }>
                    <button onClick={ ()=>{
                        setCurAction ( 'create' )
                    } } className={ st.createB }>Create
                    </button>
                    <button onClick={ ()=>{
                        setCurAction ( 'update' )
                    } } className={ st.updateB }>Update
                    </button>
                    <button onClick={ ()=>{
                        setCurAction ( 'delete' )
                    } } className={ st.deleteB }>Delete
                    </button>
                </div> }
                <FormsPage setRequest={ setRequest } curAction={ curAction } curCat={ curCat }/>
            </div>
        </div>
    );
};

export default AdmCategories;