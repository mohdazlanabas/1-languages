// QUERY SELECTOR
//const circle = document.querySelector('.circle')
//console.log(circle)

// EVENT LISTENER
const circle = document.getElementsByClassName('.circle')
function alertMe() { console.log('clicked')}
circle.addEventListener('click', alertMe)
