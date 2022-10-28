import React from 'react'
import './Employee.css'


class Employee extends React.Component{
     eid=2;
    constructor(props){
        super(props);
       // console.log("Employee constructed");
    }
    render(){
        return(
            <div className="alert alert-success">
                <h2>Employee Details</h2>
                Employee Id : {this.eid}
                <br/>
                Employee Name : {this.props.ename}
                <br/>
                Employee Age : {this.props.eage*1 +1}
                <br/>

               {new Date(2002,9,27).toISOString()}
            </div>
        );
    }
}

export default Employee;