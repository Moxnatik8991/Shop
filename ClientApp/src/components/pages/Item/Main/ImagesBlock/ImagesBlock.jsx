import React , { useState } from 'react';
import st from './ImagesBlock.module.scss'
import left from '../../../../../icons/left.png'
const images = [
    "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736881_640.jpg",
    "https://img.freepik.com/free-photo/space-background-realistic-starry-night-cosmos-shining-stars-milky-way-stardust-color-galaxy_1258-154643.jpg",
    "https://us.123rf.com/450wm/virtosmedia/virtosmedia2302/virtosmedia230209170/197936185-portrait-of-a-beautiful-young-woman-lying-on-the-grass-with-flowers.jpg?ver=6",
];
const ImagesBlock = ()=>{
    let leftClick=()=>{
        const isFirstSlide = currentIndex===0
        const newIndex = isFirstSlide?images.length-1:currentIndex-1
        setCurrentIndex(newIndex);
        setMainImage(images[newIndex])
        
    }
    let rightClick=()=>{
        const isLasttSlide = currentIndex===images.length-1
        const newIndex = isLasttSlide?0:currentIndex+1
        setCurrentIndex(newIndex);
        setMainImage(images[newIndex])

    }
    const[currentIndex,setCurrentIndex]=useState(0)
    const[mainImage,setMainImage]=useState(images[0])
    return (
        <>
            <div className={st.container}  >
                <div className={ st.mainImage }>
                    <div onClick={ ()=>{
                        leftClick ()
                    } } className={ st.testLeft }>
                        <img style={ { width : "100%" , height : "100%" } } src={ left } alt=""/>
                    </div>
                    <div onClick={ ()=>{
                        rightClick ()
                    } } className={ st.testRight }>
                        <img style={ { width : "100%" , height : "100%" } } src={ left } alt=""/>
                    </div>

                    <img src={ mainImage } alt=""/>
                </div>
                <div className={ st.imageList }>
                    { images.map ( (el , i)=><div key={el}>

                        <img className={ mainImage===el? st.clicked:""}  onClick={ ()=>{
                            setMainImage ( el );
                            setCurrentIndex(i);
                        } }  src={ el } alt=""/>
                    </div> ) }
                </div>

            </div>

        </>
    );
};

export default ImagesBlock;