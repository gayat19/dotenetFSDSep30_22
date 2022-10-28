import React, { useState } from 'react';
import './WeatherComponent.css';

function WeatherComponent(props) {
    var data; //= props;
    var [wdata,setWdata] = useState({wdate:'',
        tc:0,
        tf:0,
        wsummary:''});
    var callme=()=>{
        //alert('hello')
    setWdata(()=>{
        return {wdate:props.wdate,
                  tc:props.tc,
                  tf:props.tf,
                  wsummary:props.wsummary}
                });
    }
    
       return ( <div className='alert alert-primary weather'>
            <div>
            Date:{wdata.wdate.toString()}
            <br/>
            TemperatureC:{wdata.tc}
            <br/>
            TemperatureF:{wdata.tf}
            <br/>
            Summary:{wdata.wsummary}
            </div>
            <button onClick={callme} className='btn btn-primary'>Show</button>
            </div>)
   
}

export default WeatherComponent;