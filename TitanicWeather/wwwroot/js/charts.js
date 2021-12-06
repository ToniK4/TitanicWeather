const temp = document.getElementById('TempChart').getContext('2d');
const TempChart = new Chart(temp, {
    type: 'line',
    data: {
        labels: ['Mon', 'Tue', 'Wed', 'Thur', 'Fri', 'Sta', 'Sun'],
        datasets: [{
            label: 'High Temperature °C',
            data: [5, 2, 5, 3, 2, 6, 1],
            backgroundColor: "transparent",
            borderColor: "#ea7ccc",
            borderWidth: 3
        },

        {
            label: 'Low Temperature °C',
            data: [-5, -2, -1, -2, 0, -3,-1],
            backgroundColor: "transparent",
            borderColor: "#ee6666",
            borderWidth: 3
        },
    ]
    },
    options: {
        elements:{
            line:{
                tension:0.5
            }
        },
        scales: {
            y: {
                beginAtZero: true
            }
        }
    },
});

const humi = document.getElementById('HumiChart').getContext('2d');
const humiChart = new Chart(humi, {
    type: 'line',
    data: {
        labels: ['Mon', 'Tue', 'Wed', 'Thur', 'Fri', 'Sta', 'Sun'],
        datasets: [{
            label: 'Humidity %',
            data: [89, 84, 75, 82, 92, 88,85],
            backgroundColor: "transparent",
            borderColor: "#73c0de",
            borderWidth: 3
        },
    ]
    },
    options: {
        elements:{
            line:{
                tension:0.5
            }
        },
        scales: {
            y: {
                beginAtZero: false
            }
        }
    }
});

const wind = document.getElementById('WindChart').getContext('2d');
const windChart = new Chart(wind, {
    type: 'line',
    data: {
        labels: ['Mon', 'Tue', 'Wed', 'Thur', 'Fri', 'Sta', 'Sun'],
        datasets: [{
            label: 'Wind Speed  m/s',
            data: [2.7, 3.5, 3.2, 4.1, 4.2, 3.8,3.5],
            backgroundColor: "transparent",
            borderColor: "#fac858",
            borderWidth: 3
        },
    ]
    },
    options: {
        elements:{
            line:{
                tension:0.5
            }
        },
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});
