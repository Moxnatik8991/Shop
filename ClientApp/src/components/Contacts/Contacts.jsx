import './Contacts.css';
import React from "react";



const Contacts= ()=>{
    return(
        <div className={ 'content-wrapper' }>
            <div>
                <p>
                    About Us
                </p>
                <span>
                    Some information about shop...
                </span>
            </div>
            <div>
                <p>
                    Location
                </p>
                <span>
                    Some information about shop location...
                </span>
            </div>
            <div>
                <p>
                    Contacts
                </p>
                <div className={ 'contacts' }>
                    <div>
                        <p>Numbers</p>
                        <ul>
                            <li>+1111111111111</li>
                            <li>+1111111111111</li>
                            <li>+1111111111111</li>
                            <li>+1111111111111</li>
                        </ul>
                    </div>
                    <div>
                        <p>Emails</p>
                        <ul>
                            <li>example@gmail.com</li>
                            <li>example@gmail.com</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    )
}
export default Contacts;