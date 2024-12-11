document.addEventListener("DOMContentLoaded", function() {
    fetch('/api/essays')
        .then(response => response.json())
        .then(data => {
            const essaysDiv = document.getElementById('essays');
            data.forEach(essay => {
                const essayDiv = document.createElement('div');
                essayDiv.innerHTML = `<h2>${essay.title}</h2><p>${essay.content}</p>`;
                essaysDiv.appendChild(essayDiv);
            });
        });
});
