//.length
// Can be used on String or Array
// const word = 'banana'
// console.log(word.length)
//const fruit = ['banana', 'apple', 'pear']
//console.log(fruit.length)
//outlier
//const balls = document.querySelectorAll('.ball')
//console.log(balls.length)

//.concat()
//const string ='Cheese'
//const string2 ='Azlan'
//console.log(string.concat(string2))

// arrays
//const array1 = [0,1,2,3]
//const array2 = [4,5,6]
//const array3 = [7,8,9,10]
//const newArray = array1.concat(array2, array3)
//console.log(newArray)

//.join
// returns a New String
// const textDisplay = document.querySelector('.text')
//const emotions =[]
//const emotions = ['Happy', 'Sad','Confident']
//textDisplay.innerHTML = emotions

//.join
//const textDisplay = document.querySelector('.text')
//const emotions = ['Happy', 'Sad','Confident']
//const newWord = emotions.join('-')
//textDisplay.innerHTML = newWord

//.pop
//const display = document.querySelector('.display')
//const movies = [
//    {name:'Argo',length: '136 minutes'},
//    {name:'Aliens',length: '160 minutes'},
//    {name:'Terminator',length: '200 minutes'},]
//console.log(movies)
//movies.pop()
//display.innerHTML = movies

//.shift()
// chamges the length of an array
//const display = document.querySelector('.display'
////const movies = ['Goodfellas', 'Wolf','Jumanji']
//const count = [1,2,3,4,5]
//movies.shift()
//count.shift()
//display.innerHTML = count

//.unshift()
//const display = document.querySelector('.display')
//const plays = ['Hamilton','Cats']
//plays.unshift('Wicked')
//console.log(plays)
//display.innerHTML = plays

//.push()
// changes the original array
//const display = document.querySelector('.display')
//const actors = ['Brad Ptt']
//actors.push('Bradley Coope', 'Harrison Ford')
//display.innerHTML = actors

//.spice()
//it does not mutate arrays
//it produces a new one

//const display = document.querySelector('.display')
//const artists = ['Shakira','Snoop', 'Sia', 'Beyonce', 'Beiber']
//const maleArtists = artists.slice(1,2)
//console.log(artists.slice(1,2))
//display.innerHTML = artists
//console.log(maleArtists)

//.slice
//const artists = ['Shakira','Snoop', 'Sia', 'Beyonce', 'Beiber']
//const maleArtists = artists.slice(1,2)
//console.log(artists.slice(1,2))
//console.log(maleArtists)
//const notArtists = artists.slice(3)
//console.log(notArtists)
//const realArtists = artists.slice(0,3)
//console.log(realArtists)

//.splice
//const movies = ['elf', 'Annie', 'Hero 6']
//movies.splice(1,1, "Mulan")
//movies.splice(2,2, "Hook")
//movies.splice(2,0, "Hook")
//let spliceArray = array.splice(1,0, "Hook")
//console.log(movies)
// let splice Array = array.splice(Start, deletecount, replacement)

//.forEach
//const names = ['Ania','Bobby','Melanie']
//names.forEach(change => console.log(change))
//const scores = [32,543,43,53,24,23,42,52,78,22]
//scores.forEach(score => (console.log(score+2)))

//.some
//const scores =[88,56,76,76]
//console.log(scores.some(score => score < 50))
//const countries =['Afganostan', 'America', 'Poland', 'Singapre']
//console.log(countries.some(country => 'Polamd'))