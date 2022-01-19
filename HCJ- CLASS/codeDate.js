//DATE
const today = new Date()
const date = today.getDate()
const day = today.getDay()
const fullYear = today.getUTCFullYear()
const hours = today.getHours()
const isoString = today.toISOString()
console.log(fullYear, date, day, hours, isoString)
const Christmas = new Date('2021-12-24T00:00:00.905Z')
const milisecondsToXmas = Christmas - today
const minutes = (milisecondsToXmas / 60000).toString()
const xHours = (minutes / 60).toString()
const xDays = (xHours / 24).toString()
console.log((Math.round(minutes)), (Math.round(xHours)), (Math.round(xDays)))