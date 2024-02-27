import { useEffect, useState } from "react"
import { useSelectedOptions } from './SelectedOptionsContext';

function AltComp(props) {
    const [selectComp,setSelectedComp]=useState([]);
    const [altComp,setaltComp]=useState([]);
    const {altOptions , setaltOptions } = useSelectedOptions();

    useEffect((e)=>{
        fetch(`http://localhost:8080/api/config/${props.compoid}/${props.compo}`).then(
            res=>res.json()
         ).then(
            data=>{
              console.log(data);
              setaltComp(data)
            } 
         ); 
    },[props.compoid, props.compo])
    
    const onSelectChange = (e) => {
        const { name, value } = e.target;
        const selectedvalue = e.target.value;
        if(selectedvalue)
        {
            try{const obj=JSON.parse(value);
                const Alt_id=obj.alt_id;
            setaltOptions((altOptions) => ({
              ...altOptions,
              [name]: Alt_id,
            }));
            console.log(altOptions);}
        catch (error) {
            console.error('Error parsing JSON:', error);
            // Handle the error or provide appropriate feedback to the user
          }
        }
        else {
            // Handle the case where the value is empty (default option selected)
            console.log('Select option is selected');
          }
};
    return (
        <div>
            <div>
     <h1>{props.compo}</h1>
     <select id="Dropdown"
     name={props.compo}
     onChange={onSelectChange}>
        <option value="">Select</option>
     { altComp.map((altcmp)=>( <option value={JSON.stringify(altcmp)}key={altcmp.alt_id}>
        {altcmp.sub_type + " :₹ " + altcmp.price}
        </option>
     ))}
     </select>
        </div>
        </div>
    )
}

export default AltComp
