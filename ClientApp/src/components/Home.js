import React , { useState } from 'react';
import { Carousel } from "react-responsive-carousel";
import "react-responsive-carousel/lib/styles/carousel.min.css";
import "./Home.css"
const images = [
    "https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736881_640.jpg",
    "https://img.freepik.com/free-photo/space-background-realistic-starry-night-cosmos-shining-stars-milky-way-stardust-color-galaxy_1258-154643.jpg",
    "https://us.123rf.com/450wm/virtosmedia/virtosmedia2302/virtosmedia230209170/197936185-portrait-of-a-beautiful-young-woman-lying-on-the-grass-with-flowers.jpg?ver=6",
];
const Home = ()=>{
    const[mainImage,setMainImage]=useState(images[0])
   
    return (
        <div>
            <div style={{height:"500px",width:"500px",backgroundColor:"grey",margin:"20px"}}>
                <div style={{margin:"0 auto",width:"max-content",padding:"20px"}}>
                    <img style={{width:"150px",height:"150px"}} src={ mainImage } alt=""/>
                </div>
                <div style={{margin:"0 auto",width:"max-content",display:"flex",gap:"5px"}}>
                    {images.map(el=><div>
                        <img className={mainImage===el?"clicked":""} onClick={()=>{setMainImage(el);}} style={{width:"50px",height:"50px"}} src={el} alt=""/>
                    </div>)}
                </div>
                
            </div>
            
        </div>
    );
};

export default Home;