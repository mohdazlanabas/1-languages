// Using .fetch

// To Get Data - GET REQUEST
//fetch('https://api.punkapi.com/v2/beers')
//    .then((response) => response.json())
//    .then((data) => console.log(data))

//function getData(){
//   fetch('https://my-burger-api.herokuapp.com/burgers')
//    .then((response) => response.json())
//    .then((data) => {
//        console.log(data)
//        const name =  data[0].name
//        console.log(name)})}
//      getData()

//POST requests
// able to post data to an API
//const data = { username: 'eample'}
//fetch('https://xxx', {
//method: 'POST',
//headers : {
//    'Content-Type': 'application/json',},
//    body: JSON.stringify(data),})
//    .then(response => response.json())
//    .then(data => {
//        console.log('Success:', data)})
//        .catch((error) => {
//            console.error('Error:', error)})

// PUT REQUEST
// Allows you to edit an object
//const data = { }
//function editData () {
//    fetch('', {
////method: 'PUT',
//headers : {
//    'Content-Type': 'application/json'},
//    body: JSON.stringify(data),})
//    .then(response => response.json())
//    .then(data => {
//        console.log('Success:', data)})
//        .catch((error) => {
//            console.error('Error:', error)})}

//DELETE request
fetch('https://my-burger-api.herokuapp.com/burgers/29',{
method:' DELETE'})

