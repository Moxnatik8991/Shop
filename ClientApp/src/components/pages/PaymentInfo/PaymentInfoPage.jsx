import React , { useState } from 'react';
import st from './PaymentInfoPage.module.scss'


const delivery = [
    {
        id: "Pickup",
        name:"Самовивіз",
        element: <>
            <div className={ st.description }>
                <div className={ st.text }>
                    Якщо зробили замовлення до 19:00 - можете забрати покупку у той самий день.
                    Замовили після 19:00 - забирайте наступного дня
                </div>
                <div className={ st.blocks }>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img1.png" alt=""/>
                        <span>Через 1 год після замовлення, якщо товар в наявності</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img2.png" alt=""/>
                        <span>Будь-який товар</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img3.png" alt=""/>
                        <span>У зручному для вас магазині або Comfy точці</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img4.png" alt=""/>
                        <span>Безкоштовно</span>
                    </div>
                </div>
            </div>
            <div className={ st.instruction }>
                <div className={ st.text }>
                    Як купити товар у самовивіз:
                </div>
                <div className={ st.blocks }>
                    <div>
                        <div>
                            <p>01</p>
                            <span>Під час оформлення вказуєте: "Самовивіз з магазину"</span>
                        </div>

                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img5.png" alt=""/>

                    </div>
                    <div>
                        <div>
                            <p>02</p>
                            <span>Вибираєте зручний магазин або Comfy точку зі списку</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img6.png" alt=""/>

                    </div>
                    <div>
                        <div>
                            <p>03</p>
                            <span>Після оформлення вам надійде СМС або Viber-повідомлення з інформацією про замовлення</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img7.png" alt=""/>

                    </div>
                    <div>
                        <div>
                            <p>04</p>
                            <span>Отримайте товар у зоні видачі онлайн-покупок в магазині, або в Comfy точці</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img8.png" alt=""/>

                    </div>
                </div>
            </div>
        </>
    },
    {
        id: "courierNP",
        name:'Кур’єром від "Нова Пошта"',
        element: <>
            <div className={ st.description }>
                <div className={ st.blocks }>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img1.png" alt=""/>
                        <span><a href="https://novaposhta.ua/" target="_blank" rel="noreferrer">Відстежити посилку →</a></span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img2.png" alt=""/>
                        <span>До 100 кг <br/>До 150 х 185 х 170 см</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img3.png" alt=""/>
                        <span>До вас додому</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img4.png" alt=""/>
                        <span>Дрібногабаритний - 199 ₴ з ПДВ <br/> Великогабаритний - 699 ₴ з ПДВ</span>
                    </div>
                </div>
            </div>
            <div className={ st.positive }>
                <div className={ st.text }>
                    Переваги:
                </div>
                <div className={ st.blocks }>
                    <div>
                        <p>Статус доставки</p>
                        <span>Завжди знаєте, де знаходиться ваша посилка: із SMS, контакт-центру,
                                особистого кабінету або мобільного додатка «Нової Пошти»</span>
                    </div>
                    <div>
                        <p>Приходить вчасно</p>
                        <span>87% усіх доставок за адресою виконуються у зазначений термін</span>
                    </div>
                    <div>
                        <p>Клієнти задоволені</p>
                        <span>Рівень задоволеності клієнтів кур'єрською доставкою «Нової пошти» — 8,66 з 9</span>
                    </div>

                </div>
                <div className={ st.star }>
                    * У день доставки та за годину до приїзду ми вам зателефонуємо. Якщо не додзвонимося - відправимо SMS
                </div>
            </div>
            <div className={ st.instruction }>
                <div className={ st.text }>
                    Як купити товар з кур'єрською доставкою «Нової пошти»
                </div>
                <div className={ st.blocks }>
                    <div>
                        <div>
                            <p>01</p>
                            <span>Під час оформлення вказуєте: «Нова Пошта» кур'єр</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost6_img2.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>02</p>
                            <span>Вказуєте дату доставки</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost2_img1.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>03</p>
                            <span>Заповнюєте інші необхідні поля</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost2_img2.png" alt=""/>

                    </div>
                </div>
            </div>
        </>
    },
    {
        id: "departmentNP",
        name:'До відділення "Нова Пошта"',
        element: <>
            <div className={ st.description }>
                <div className={ st.blocks }>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img1.png" alt=""/>
                        <span><a href="https://novaposhta.ua/" target="_blank" rel="noreferrer">Відстежити посилку →</a></span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img2.png" alt=""/>
                        <span>До 100 кг <br/>До 150 х 185 х 170 см</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img3.png" alt=""/>
                        <span>Будь-яке зручне <a href="https://novaposhta.ua/office/list" target="_blank" rel="noreferrer">відділення</a></span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img4.png" alt=""/>
                        <span>Дрібногабаритний - 99 ₴ з ПДВ <br/> Великогабаритний - 499 ₴ з ПДВ</span>
                    </div>
                </div>
            </div>
            <div className={ st.positive }>
                <div className={ st.text }>
                    Переваги:
                </div>
                <div className={ st.blocks }>
                    <div>
                        <p>Статус доставки</p>
                        <span>Завжди знаєте, де знаходиться ваша посилка: із SMS, контакт-центру,
                                особистого кабінету або мобільного додатка «Нової Пошти»</span>
                    </div>
                    <div>
                        <p>Приходить вчасно</p>
                        <span>87% усіх доставок за адресою виконуються у зазначений термін</span>
                    </div>
                    <div>
                        <p>Більше 9000 відділень</p>
                        <span>На всій території України</span>
                    </div>

                </div>

            </div>
            <div className={ st.instruction }>
                <div className={ st.text }>
                    Як купити товар з доставкою до відділення “Нової пошти”
                </div>
                <div className={ st.blocks }>
                    <div>
                        <div>
                            <p>01</p>
                            <span>Під час оформлення вказуєте: «Нова пошта» у відділення</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost6_img2.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>02</p>
                            <span>Вказуєте дату доставки та номер відділення</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost2_img1.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>03</p>
                            <span>Заповнюєте інші необхідні поля</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost2_img2.png" alt=""/>

                    </div>
                </div>
            </div>
        </>
    },
    {
        id: "poshtomatNP",
        name:'До поштомату "Нова Пошта"',
        element: <>
            <div className={ st.description }>
                <div className={ st.blocks }>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img1.png" alt=""/>
                        <span><a href="https://novaposhta.ua/" target="_blank" rel="noreferrer">Відстежити посилку →</a></span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img2.png" alt=""/>
                        <span>Вартість товару до 10 000 ₴<br/>Вага до 30 кг<br/>Об'єм до 40 х 60 х 30 см</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img3.png" alt=""/>
                        <span>До поштомату<br/><a href="https://novaposhta.ua/office/list"
                                                  target="_blank" rel="noreferrer">Список поштоматів</a></span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img4.png" alt=""/>
                        <span>Вартість доставки 89 ₴ с ПДВ</span>
                    </div>
                </div>
            </div>
            <div className={ st.positive }>
                <div className={ st.text }>
                    Переваги:
                </div>
                <div className={ st.blocks }>
                    <div>
                        <p>Без черг</p>
                        <span>Щоб забрати замовлення, потрібен лише додаток "Нова Пошта" або код із SMS</span>
                    </div>
                    <div>
                        <p>Без документів</p>
                        <span>87% усіх доставок за адресою виконуються у зазначений термін</span>
                    </div>
                    <div>
                        <p>Безпечно для здоров’я</p>
                        <span>Не потрібно спілкуватися з кур'єром або оператором відділення</span>
                    </div>
                    <div>
                        <p>Більше 11 000 поштоматів</p>
                        <span>На всій території України</span>
                    </div>

                </div>

            </div>
            <div className={ st.instruction }>
                <div className={ st.text }>
                    Як купити товар з доставкою до поштомату «Нової пошти»
                </div>
                <div className={ st.blocks }>
                    <div>
                        <div>
                            <p>01</p>
                            <span>Під час оформлення вказуєте: «Нова Пошта» в поштомат</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost6_img2.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>02</p>
                            <span>Вказуєте дату та номер / адресу поштомату</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost2_img1.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>03</p>
                            <span>
                                    Коли замовлення надійде, у ваш додаток "Нова Пошта" прийде повідомлення
                                    <br/>
                                    <a target="_blank"
                                       href="https://www.youtube.com/watch?v=3QS8HxLnvGA&feature=youtu.be" rel="noreferrer">
                                        Детальніше →
                                    </a>
                                </span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost7_img1.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>04</p>
                            <span>Підходите до поштомату та забираєте товар</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost7_img2.png" alt=""/>
                    </div>
                </div>
            </div>
        </>
    },
    {
        id: "departmentUP",
        name:'До відділення "Укрпошта"',
        element: <>
            <div className={ st.description }>
                <div className={ st.blocks }>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img1.png" alt=""/>
                        <span><a href="https://track.ukrposhta.ua/tracking_UA.html"
                                 target="_blank" rel="noreferrer">Відстежити посилку →</a></span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img2.png" alt=""/>
                        <span>Вага до 30 кг<br/>Довжина до 70 см</span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img3.png" alt=""/>
                        <span>У відділення "Укрпошти"<br/><a href="https://offices.ukrposhta.ua/"
                                                             target="_blank" rel="noreferrer">Мапа відділень</a></span>
                    </div>
                    <div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost1_img4.png" alt=""/>
                        <span>Дрібногабаритний - 69 ₴ з ПДВ<br/>Великогабаритний - 69 ₴ з ПДВ</span>
                    </div>
                </div>
            </div>
            <div className={ st.positive }>
                <div className={ st.text }>
                    Переваги:
                </div>
                <div className={ st.blocks }>
                    <div>
                        <p>Завжди поруч</p>
                        <span>Отримання відправлення у будь-якому куточку України. Понад 11 000 точок видачі. Мережа Укрпошти покриває 100% території України: 29 000 населенних пунктів</span>
                    </div>
                    <div>
                        <p>Статус доставки</p>
                        <span>Вам буде надіслано SMS або Viber-повідомлення про прибуття відправлення у відділення.</span>
                    </div>
                    <div>
                        <p>Оптимальні терміни доставки</p>
                        <span>від 2-х до 5-ти днів</span>
                    </div>
                    <div>
                        <p>Безкоштовно зберігаємо</p>
                        <span>Безкоштовне зберігання посилки 7 днів</span>
                    </div>
                </div>

            </div>
            <div className={ st.instruction }>
                <div className={ st.text }>
                    Як купити товар з доставкою "Укрпошта"
                </div>
                <div className={ st.blocks }>
                    <div>
                        <div>
                            <p>01</p>
                            <span>Під час оформлення замовлення вказуєте: "Укрпошта" до відділення</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/urkpochtaimg.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>02</p>
                            <span>Заповнюєте інші необхідні поля</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost5_img3.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>03</p>
                            <span>
                                    Коли замовлення буде доставлено, прийде SMS або Viber-повідомлення
                                </span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost7_img1.png" alt=""/>
                    </div>
                    <div>
                        <div>
                            <p>04</p>
                            <span>Називаєте номер із SMS або Viber-повідомлення оператору відділення</span>
                        </div>
                        <img src="https://cdn.comfy.ua/media/x/img2/delivery/sect_dost8_img2.png" alt=""/>
                    </div>
                </div>
            </div>
        </>
    },
]
const PaymentInfoPage = ()=>{
    const [curMethod,setCurMethod]=useState(delivery[0].element)
    const chooseDelivery=(element)=>{
        setCurMethod(element)
    }
    return (
        <div className={ st.container }>
            <div className={ st.metodsContainer }>
                {delivery.map(el=>{
                    return (
                        <div key={el.id} onClick={()=>{chooseDelivery(el.element)}}>
                            <span>{ el.name }</span>
                            <span style={ { float : "right" } }> > </span>
                        </div>
                    )
                } ) }
            </div>
            <div className={ st.contentContainer }>
                {curMethod}
            </div>
        </div>
    );
};

export default PaymentInfoPage;