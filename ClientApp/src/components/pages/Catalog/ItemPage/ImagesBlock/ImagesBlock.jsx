import React , { useState } from 'react';
import st from './ImagesBlock.module.scss'
const images = [
    "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736881_640.jpg",
    "https://img.freepik.com/free-photo/space-background-realistic-starry-night-cosmos-shining-stars-milky-way-stardust-color-galaxy_1258-154643.jpg",
    "https://us.123rf.com/450wm/virtosmedia/virtosmedia2302/virtosmedia230209170/197936185-portrait-of-a-beautiful-young-woman-lying-on-the-grass-with-flowers.jpg?ver=6",
];
const ImagesBlock = ()=>{
    const[mainImage,setMainImage]=useState(images[0])
    return (
        <>
            <div className={st.container}  >
                <div className={ st.mainImage }>
                    
                    <img src={ mainImage } alt=""/>
                </div>
                <div className={st.imageList} >
                    { images.map ( el=><div>
                        
                        <img className={mainImage===el? st.clicked:""}  onClick={ ()=>{
                            setMainImage ( el );
                        } }  src={ el } alt=""/>
                    </div> ) }
                </div>

            </div>

        </>
    );
};

export default ImagesBlock;