// class Employee
// {
//     constructor(id,name,address,salary){
//         this.id=id
//         this.name=name
//         this.address=address
//         this.salary=salary
//     }
// }


// class EmployeeRepo
// {
//     empList=[]; //Create a blank array
//     addEmp = (emp) => {
//     this.empList = [...this.empList, emp];
// }

//    // removeEmp=(id)=>this.empList=this.empList.filter(emp=>emp.id!=id)
//    removeEmp=(id)=>{
//     const index=this.empList.findIndex(e=>e.id==id)
//     if(index>=0)
//     {
//         this.empList.splice(index,1)
//     }
//    }

//     updateEmp=(emp)=>{
//     const index=this.empList.findIndex(e=>e.id==emp.id)
//     if(index>=0)
//     {
//         this.empList.splice(index,1,emp)  //1 is added for removal , 0 is for insertion and emp is the one replacing the current emp record
//     }
//    }

//    getAll=()=>this.empList;

//    getEmp=(id)=>this.empList.find((e)=>e.id==id)

// }
class Employee {
    constructor(id, name, address, salary) {
        this.id = id;
        this.name = name;
        this.address = address;
        this.salary = salary;
    }
}

class EmployeeRepo {
    empList = [];

    addEmp = (emp) => {
        this.empList = [...this.empList, emp];
    }

    removeEmp = (id) => {
        const index = this.empList.findIndex(e => e.id == id);
        if (index >= 0) {
            this.empList.splice(index, 1);
        }
    }

    updateEmp = (emp) => {
        const index = this.empList.findIndex(e => e.id == emp.id);
        if (index >= 0) {
            this.empList.splice(index, 1, emp);
        }
    }

    getAll = () => this.empList;

    getEmp = (id) => this.empList.find(e => e.id == id);
}
