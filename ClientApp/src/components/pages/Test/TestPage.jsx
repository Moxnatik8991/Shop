import React , { useEffect , useState } from 'react';

const testFunk1=(arg,setTestParam3)=>{
    debugger
    let res = arg+2
    return res
}
const testFunk2=(arg)=>{0
    debugger
    let res = arg+10;
    return res
}
const TestPage = ()=>{
    const [testParam1,setTestParam1]=useState(1)
    const [testParam2,setTestParam2]=useState()
    const [testParam3,setTestParam3]=useState()
    const testFunk=()=>{
        setTestParam1(prevState=>prevState+1)
    }
    console.log("par1 "+testParam1)
    console.log("par2 "+testParam2)
    console.log("par3 "+testParam3)
    useEffect ( ()=>{
        let tess = testFunk1(10)
        setTestParam2(tess)
        setTestParam3(testFunk2(tess))
    } , [testParam1] );
    return (
        <div>
            <button onClick={testFunk}> do both</button>
        </div>
    );
};

export default TestPage;