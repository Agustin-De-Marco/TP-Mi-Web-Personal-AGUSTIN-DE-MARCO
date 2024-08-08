
const rocket = document.getElementById('rocket');
let direction = 'toMoon';

function animateRocket() {
    if (direction === 'toMoon') {
        rocket.classList.add('fire');
        rocket.style.animation = 'moveToMoon 5s forwards';
        setTimeout(() => {
            rocket.classList.remove('fire');
            direction = 'toEarth';
            setTimeout(animateRocket, 1000); // espera 1 segundo antes de comenzar el regreso
        }, 5000); // duración de la animación
    } else {
        rocket.classList.add('fire');
        rocket.style.animation = 'moveToEarth 5s forwards';
        setTimeout(() => {
            rocket.classList.remove('fire');
            direction = 'toMoon';
            setTimeout(animateRocket, 1000); // espera 1 segundo antes de comenzar el despegue
        }, 5000); // duración de la animación
    }
}

// Inicia la animación
animateRocket();