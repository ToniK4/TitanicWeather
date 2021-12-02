function getRoomTemp(){
    axios({
      method: 'get',
      url: 'https://titanicweatherapi.azurewebsites.net/api/Titanic/Recent'
    })
    .then(res=>ShowRoomTemp(res))
    .catch(err=>console.log(err));
}
function ShowRoomTemp(res){
  
  document.getElementById('temp').innerHTML = `
    ${JSON.stringify(res.data.temperature)}
    `;
  document.getElementById('humid').innerHTML = `
    ${JSON.stringify(res.data.humidity)}
    `;
}

getRoomTemp();