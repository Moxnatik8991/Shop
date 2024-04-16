import axios from "axios";


const BASE_URL = "https://5iaf6t.realhost-free.net/api/Auth"
const $api = axios.create({

        baseURL:BASE_URL
    }
)

export default $api;

/*
const baseUrl = "https://5iaf6t.realhost-free.net/api/User/Get"
export const $apiUsers= axios.create({
    baseURL: baseUrl
})
$apiUsers.interceptors.request.use((config)=>{
    config.headers.Authorization = `Bearer ${localStorage.getItem("token")}`
    return config
})
*/





const BASE_URL_COMMENTS = "https://5iaf6t.realhost-free.net/api/Comment/";
export const $apiComments = axios.create(
    {
        baseURL: BASE_URL_COMMENTS
    }
)
export const ApiComments = {
    getAll: async ()=>{
        let response = await $apiComments.get('GetAll')
        return response.data.result
    },
    getByProductId: async (id)=>{
        let response = await $apiComments.get(`GetCommentsByProductId/${id}`)
        return response.data.result
    },
    getById: async (id)=>{
        let response = await $apiComments.get(`Get/${id}`)
        return response.data.result
    },
    addNew: async (data)=>{
        try {
            let response = await $apiComments.post(`Add`,data)
            return response.data
        }
        catch (error){
            return { error: error.message }
        }
        
    }, 
    change: async (id,data)=>{
        try {
            let result = await $apiComments.put(`Put/${id}`,data)
            return result.data
        }
        catch (error){
            return    error.response.data
        }
    },
    delete: async (id)=>{
        let response = await $apiComments.get(`Get/${id}`)
        return response.data.result
    },
}


const BASE_URL_ITEMS = "https://5iaf6t.realhost-free.net/api/Product/";
export const $apiItems = axios.create(
    {
        baseURL: BASE_URL_ITEMS
    }
)
export const ApiItems = {
    getAll: async ()=>{
        let result = (await $apiItems.get('GetAll')).data.result
        return result
    },
    getById: async (id)=>{
        let result = (await $apiItems.get(`Get/${id}`)).data.result
        return result
    },
    getWithFilter: async (object)=>{
        let test1 = JSON.stringify( object)
        let test = encodeURIComponent( `[${test1}]`)
        try {
            let result = await $apiItems.get(`GetWithFilteringAndPagination?OrderBy=${test}`)
            debugger
            return result.data.result
        } 
        catch (error){
        debugger    
        }
        
    },
}



const BASE_URL_CATEGORY = "https://5iaf6t.realhost-free.net/api/Category/";
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
    addNew: async (data)=>{
        let result = (await $apiCategory.post(`Add`,data)).data.isSuccess
        return result
    },
    change: async (id,data)=>{
        try {
            let result = await $apiCategory.put(`Put/${id}`,data)
            return result.data
        }catch (error){
            return    error.response.data
        }
    },
    delete: async (id)=>{
        try {
            let result = await $apiCategory.delete(`Delete/${id}`)
            return result.data
        }catch (error){
           
         return    error.response.data
        }
    },

}