function solve() {
    const buttonElement = document.getElementById('add-worker');
    const fNameInputElement = document.getElementById('fname');
    const lNameInputElement = document.getElementById('lname');
    const emailInputElement = document.getElementById('email');
    const birthDateInputElement = document.getElementById('birth');
    const positionInputElement = document.getElementById('position');
    const salaryInputElement = document.getElementById('salary');
    const tbodyElement = document.getElementById('tbody');

    let totalBudget = 0;

    
    buttonElement.addEventListener('click', hireWorker);

    function hireWorker(event){
        event.preventDefault();
        
        let fName = fNameInputElement.value;
        let lName = lNameInputElement.value;
        let email = emailInputElement.value;
        let birth = birthDateInputElement.value;
        let position = positionInputElement.value;
        let salary = salaryInputElement.value;

        if (!fName || !lName || !email || !birth || !position || !salary) {
            return
        }

        fNameInputElement.value = '';
        lNameInputElement.value = '';
        emailInputElement.value = '';
        birthDateInputElement.value = '';
        positionInputElement.value = '';
        salaryInputElement.value = '';

        let tableRowElement = document.createElement('tr');
        let fNameTableDataElement = document.createElement('td');
        let lNameTableDataElement = document.createElement('td');
        let emailTableDataElement = document.createElement('td');
        let birthTableDataElement = document.createElement('td');
        let positionTableDataElement = document.createElement('td');
        let salaryTableDataElement = document.createElement('td');
        let actionTableDataElement = document.createElement('td');

        let firedButton = document.createElement('button');
        let editButton = document.createElement('button');
        editButton.textContent = 'Edit'
        editButton.classList.add('edit');
        editButton.addEventListener('click', editWorkerData);
        
        firedButton.textContent = 'Fired'
        firedButton.classList.add('fired');
        firedButton.addEventListener('click', fireWorker);

        actionTableDataElement.appendChild(firedButton);
        actionTableDataElement.appendChild(editButton);
        
        fNameTableDataElement.textContent = fName;
        lNameTableDataElement.textContent = lName;
        emailTableDataElement.textContent = email;
        birthTableDataElement.textContent = birth;
        positionTableDataElement.textContent = position;
        salaryTableDataElement.textContent = salary;

        tableRowElement.appendChild(fNameTableDataElement);
        tableRowElement.appendChild(lNameTableDataElement);
        tableRowElement.appendChild(emailTableDataElement);
        tableRowElement.appendChild(birthTableDataElement);
        tableRowElement.appendChild(positionTableDataElement);
        tableRowElement.appendChild(salaryTableDataElement);
        tableRowElement.appendChild(actionTableDataElement);

        tbodyElement.appendChild(tableRowElement);

        totalBudget += Number(salary);
        document.getElementById('sum').textContent = totalBudget.toFixed(2)
    }

    function editWorkerData(event){
        let button = event.currentTarget
        let row = button.parentElement.parentElement;
        let data = row.children;

        fNameInputElement.value = data[0].textContent;
        lNameInputElement.value = data[1].textContent;
        emailInputElement.value = data[2].textContent;
        birthDateInputElement.value = data[3].textContent;
        positionInputElement.value = data[4].textContent;
        salaryInputElement.value = data[5].textContent;

        totalBudget -= Number(data[5].textContent);
        document.getElementById('sum').textContent = totalBudget.toFixed(2);

        tbodyElement.removeChild(row);
    }

    function fireWorker(event){
        let row = event.currentTarget.parentElement.parentElement;
        let data = row.children;
        totalBudget -= Number(data[5].textContent);
        document.getElementById('sum').textContent = totalBudget.toFixed(2);
        tbodyElement.removeChild(row);
    }
}
solve()