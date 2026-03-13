const form = document.querySelector('form');
const input = document.querySelector('input');
const ul = document.querySelector('ul');
const taskCount = document.querySelector('#task-count'); 

let count = 0; 

form.addEventListener('submit', function(event) {
    event.preventDefault();

    const task = input.value;

    if (task) {
        const li = document.createElement('li');
        li.textContent = task;
        ul.appendChild(li);
        count++; 
        taskCount.textContent = count; 
        input.value = '';
    }
});