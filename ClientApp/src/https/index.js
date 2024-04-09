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


const BASE_URL_CATEGORY = "http://localhost:2222/api/Category/";
export const $apiCategory = axios.create(
    {
        baseURL: BASE_URL_CATEGORY
    }
)
export const ApiCategory = {
    getAll: async ()=>{
        let result = (await $apiCategory.get('GetAll')).data.result
        return result
    },
    getById: async (id)=>{
        let result = (await $apiCategory.get(`Get/${id}`)).data.result
        return result
    },
    
    
}