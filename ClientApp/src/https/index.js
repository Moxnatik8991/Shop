import axios from "axios";


const BASE_URL = "http://localhost:2222/api/Auth" 
const $api = axios.create({
    
    baseURL:BASE_URL
    }
)

export default $api;

const baseUrl = "http://localhost:2222/api/User/Get"
export const $apiUsers= axios.create({
    baseURL: baseUrl
})
$apiUsers.interceptors.request.use((config)=>{
    config.headers.Authorization = `Bearer ${localStorage.getItem("token")}`
    return config
})