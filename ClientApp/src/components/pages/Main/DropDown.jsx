import React , { useState } from 'react';
import st from './DropDown.module.scss';
import ExpandMoreIcon from "@mui/icons-material/ExpandMore";

const DropDown = ({selected,setSelected})=>{
    const [isOpened,setIsOpened]=useState(false)
    const options = [
        {
            name:'От дешевых к дорогим',
            value: 'price',
            desc: false
        },
        {
            name:'От дорогих к дешевым',
            value: 'price',
            desc: true
        },
        {
            name:'По просмотрам',
            value: 'countViews',
            desc: true
        },
        {
            name:'по рейтингу',
            value: 'rating',
            desc: true
        }
    ]
    return(
        <div className={st.container}>
            <div className={st.select} onClick={()=>{setIsOpened(prevState=>!prevState)}}>
                <div style={{textAlign:"center"}}>
                    {selected?selected.name:"chose one"}
                </div>
                <div style={{display:"flex",placeItems:"center"}}
                >
                    <ExpandMoreIcon fontSize="small"/>
                </div>

            </div>
            { isOpened &&
                <div className={ st.optionsContainer }>
                    {
                        options.map ( el=><button 
                            disabled={selected?.name===el.name} 
                            key={el.name} 
                            onClick={ ()=>{
                            setSelected ( el )
                            setIsOpened(false)}} 
                            className={ st.option }
                        >
                            { el.name }
                        </button> )
                    }
                </div>
            }

        </div>
    )
};

export default DropDown;