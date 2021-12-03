function getRoomTemp() {
  axios({
    method: 'get',
    url: 'https://titanicweatherapi.azurewebsites.net/api/Titanic/Recent'
  })
    .then(res => ShowRoomTemp(res))
    .catch(err => console.log(err));
}
function ShowRoomTemp(res) {

  document.getElementById('temp').innerHTML = `
    ${JSON.stringify(res.data.temperature)}
    `;
  document.getElementById('humid').innerHTML = `
    ${JSON.stringify(res.data.humidity)}
    `;
}
function ButtonClick() {
  axios({
    method: 'post',
    url: 'https://titanicweatherapi.azurewebsites.net/api/Titanic/SetCommand',
    data: {integer:3},
    headers: {contentType: "application/json; charset=utf-8"}
    
    
    
  })
    .then(function (response) {
      console.log(response);
    })
    .catch(function (error) {
      console.log(error);
    });
    console.log("1")
}
getRoomTemp();
document.getElementById("getdata").addEventListener("click", ButtonClick);

