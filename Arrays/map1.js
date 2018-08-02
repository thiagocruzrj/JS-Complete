const nums = [1, 2, 3, 4, 5]

// For com propósito 
let resulta = nums.map(function(e) {
    return e * 2
})

console.log(resulta)

const soma10 = e => e + 10 // arrow function retorno implicito
const triplo = e => e * 3
const paraDinheiro = e => `R$ ${parseFloat(e).toFixed(2).replace('.', ',')}`

resulta = nums.map(soma10).map(triplo).map(paraDinheiro)
console.log(resulta)