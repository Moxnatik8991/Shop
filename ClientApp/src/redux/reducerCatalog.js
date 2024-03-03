import { createSlice } from '@reduxjs/toolkit'

export const catalogSlice = createSlice({
    name: 'catalog',
    initialState: {
        items: [
            {test: 0},
            {test: 0}
        ]
    },
    reducers: {
        getCatalog: (state, data) => {
            state.items = data
        }
    }
});

export const {getCatalog} = catalogSlice.actions;
export default catalogSlice.reducer;