import React , { useRef } from 'react';


const Description = ({item})=>{
    let payment = useRef()
    let testFunk=(el,e)=>{
        e.textContent === "Show"?e.textContent = "Hide": e.textContent = "Show"
        debugger
        if(el.current.style.height==="3rem")
        {
            el.current.style.height="fit-content";
            el.current.style.whiteSpace="normal"
        }
        else
        {
            el.current.style.height="3rem";
            el.current.style.whiteSpace="nowrap"
        }

        debugger

    }
    return (
        <div>
            <div>
                <h3>{  item?.name }</h3>
            </div>
            <div className="first-block">
                <div><span>Seller</span> : Yaroslav</div>
                <div>

                    <span>Price </span> : { item?.price }${ "   " }
                    <button>Add to Bucket</button>
                </div>
                <div style={ { border : "none" } }>
                    Now available!
                </div>

            </div>
            <div className="first-block">
                <div style={ { border : "none" } }>
                    Different sub parameters!
                </div>

            </div>
            <div className="first-block">
                <div>
                    <span>Delivery to Yor city</span>
                </div>
                <div>
                    <span>Pickup by yourself </span> >
                    <span> few days</span> >
                    <span> Free</span>
                </div>
                <div>
                    <span>Delivery with Nova Poshta </span> >
                    <span> 3 - 5 days </span> >
                    <span> 50 - 100 $</span>
                </div>
                <div style={ { border : "none" } }>
                    <span>Delivery by courier Yaroslav </span> >
                    <span> 1 - 99 days </span> >
                    <span> 2 000 - 10 000 $</span>
                </div>

            </div>
            <div className="first-block">
                <div ref={ payment } className="test-hide" style={ { height : "3rem" } }>
                    <button onClick={ (e)=>{
                        testFunk ( payment , e.currentTarget )
                    } }>Show
                    </button>
                    <span>Payment : </span>
                    Payment by card at the branch, Payment upon receipt of goods, Google Pay, Online card, Non-cash for
                    legal entities, Pay online with the social card "Pakunok Malyuka", Non-cash for individuals, Visa,
                    Apple Pay, Mastercard
                </div>
                <div style={ { border : "none" } }>
                    <span>Guarantee : </span> 12 months Exchange/return of goods within 14 days
                </div>

            </div>
        </div>
    );
};


export default Description;