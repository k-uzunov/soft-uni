function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
      let input = JSON.parse(document.querySelector('#inputs textarea').value);
      let avgSalary = 0;
      let totalSalary = 0;
      let currAvgSalary = 0;
      let bestName = '';
      let output = {};

      for(const line of input){
         let restaurantInfo = line.split(' - ');
         let restaurantName = restaurantInfo.shift();
         let workersData = restaurantInfo[0].split(', ');
         
         for (const worker of workersData) {
            let[name, salary] = worker.split(" ");
            if(!output.hasOwnProperty(restaurantName)){
               output[restaurantName] = {};
            }
            if (output.hasOwnProperty(restaurantName)) {
               output[restaurantName][name] = Number(salary);
            }
         }
      }

      let entries = Object.entries(output);
      for (const entry of entries) {
         let key = entry[0];
         let values = Object.values(entry[1]);
         
         for (const salary of values) {
            totalSalary += salary;
         }
         avgSalary = totalSalary / values.length;

         if (avgSalary > currAvgSalary) {
            currAvgSalary = avgSalary;
            bestName = key;
            totalSalary = 0;
         }
      }
      let result = Object.entries(output[bestName]).sort((a, b) => b[1] - a[1]);
      let print = '';

      result.forEach(w => print += `Name: ${w[0]} With Salary: ${w[1]} `);
      document.querySelector("#bestRestaurant p").textContent = `Name: ${bestName} Average Salary: ${currAvgSalary.toFixed(2)} Best Salary: ${result[0][1].toFixed(2)}`;
      document.querySelector("#workers p").textContent = print;
   }
   
}

/*
      let input = JSON.parse(document.querySelector("#inputs textarea").value);
      let restaurants = {};
      let bestRestaurant;
      for (const item of input) {
         let[restaurantName, rest] = item.split(' - ');
         rest = rest.split(", ");
         if (!restaurants[restaurantName]) {
            restaurants[restaurantName] = {}
         }
         
         for (const element of rest) {
            let[emloyee, salary] = element.split(" ");
            restaurants[restaurantName][emloyee] = salary;
         }
      }
      
      let restaurantKeys = Object.keys(restaurants);
      for (const key of restaurantKeys) {
         let salaries = Object.values(restaurants[key]).map(Number)
         let topSalary = Math.max(...salaries);
         let averageSalary = Number((salaries.reduce((a,b) => a + b, 0) / salaries.length).toFixed(2));
         restaurants[key]['Best Salary'] = topSalary;
         restaurants[key]['Average Salary'] = averageSalary;
         if (!bestRestaurant) {
               bestRestaurant = JSON.parse(JSON.stringify(restaurants[key]));
               bestRestaurant.name  = key;
         }else{
            if(bestRestaurant['Average Salary'] < restaurants[key]['Average Salary']){
               bestRestaurant = JSON.parse(JSON.stringify(restaurants[key]));
               bestRestaurant.name  = key;
            }
         }
      }

      let bestRestEmployees = Object.entries(bestRestaurant).sort((a, b) => {b[1] - a[1]});
      bestRestEmployees.splice(bestRestEmployees.length-3)
      let employees = "";
      for (const item of bestRestEmployees) {
         employees += `Name: ${item[0]} With Salary: ${item[1]} `
      }
      document.querySelector("#bestRestaurant p").textContent = `Name: ${bestRestaurant['name']} Average Salary: ${bestRestaurant['Average Salary'].toFixed(2)} Best Salary: ${bestRestaurant['Best Salary'].toFixed(2)}`
      document.querySelector("#workers p").textContent = employees.trim();
      */