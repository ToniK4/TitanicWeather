const tempPi = document.getElementById('TempChartPi').getContext('2d');
const TempChartPi = new Chart(tempPi, {
    type: 'line',
    data: {
        labels: ['Mon', 'Tue', 'Wed', 'Thur', 'Fri', 'Sta', 'Sun'],
        datasets: [{
            label: 'Temperature °C',
            data: [5, 2, 5, 3, 2, 6, 1],
            backgroundColor: "transparent",
            borderColor: "#ee6666",
            borderWidth: 3
        }
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
