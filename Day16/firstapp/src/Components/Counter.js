import React, { useState } from 'react';




function Counter(props) {
    const [number,setNumebr] = useState(0)
    var incement=()=>{
        props.onIncrement(number)
    }
   var changeNumber=(event)=>{
        setNumebr(event.target.value);
    };
    return (
        <div>
            <input type="number" onChange={changeNumber}/>
            <button onClick={incement} className="btn btn-success">Increment counter</button>
        </div>
    );
}

export default Counter;