<template>
    <div class="Echarts">
        <div :id="echartId" style="width:300px;height:200px;"></div>
    </div>
</template>

<script>
    import * as echarts from 'echarts/core';
    import { GaugeChart } from 'echarts/charts';
    import { CanvasRenderer } from 'echarts/renderers';
    echarts.use([GaugeChart, CanvasRenderer]);

    export default {
        name: 'Gauge',
        props: {
            echartId: String,
            echartColor: String,
            echartValue: Number,
            echartUnit: String
        },

        methods: {
            myEcharts() {
                var chartDom = document.getElementById(this.echartId);
                var myChart = echarts.init(chartDom, 'dark');
                var option;
                const gaugeData = [
                    {
                        value: this.echartValue,
                        name: this.echartUnit,   
                        itemStyle: {
                            color: this.echartColor
                        },

                        title: {
                            offsetCenter: ['0%', '50%'], 
                            fontSize: 14,
                            fontWeight: 'bolder',
                            color: this.echartColor,
                        },

                        detail: {
                            valueAnimation: true,    
                            offsetCenter: ['00%', '00%']
                        }
                    }
                ];
                option = {
                    series: [
                        {
                            type: 'gauge',
                            startAngle: 90,
                            endAngle: -270,
                            pointer: {
                                show: false
                            },
                            progress: {
                                show: true,
                                overlap: false,
                                roundCap: true,
                                clip: false,
                                itemStyle: {
                                    borderWidth: 1,
                                    borderColor: this.echartColor
                                }
                            },
                            axisLine: {
                                lineStyle: {
                                    width: 10
                                }
                            },
                            splitLine: {
                                show: false,
                                distance: 0,
                                length: 10
                            },
                            axisTick: {
                                show: false
                            },
                            axisLabel: {
                                show: false,
                                distance: 50
                            },
                            data: gaugeData,
                            title: {
                                fontSize: 14
                            },
                            detail: {
                                width: 50,
                                height: 14,
                                fontSize: 28,
                                color: 'auto',
                                borderColor: '',
                                borderRadius: 20,
                                borderWidth: 0,
                                formatter: '{value}',
                            }
                        }
                    ]
                };

                // simulation the dynamic data which should get from API
                setInterval(function () {
                    gaugeData[0].value = +(Math.random() * 100).toFixed(2);
                    myChart.setOption({
                        series: [
                            {
                                data: gaugeData,
                                pointer: {
                                    show: false
                                }
                            }
                        ]
                    });
                }, 2000);

                option && myChart.setOption(option);
            }
        },
        mounted() {
            this.myEcharts();
        }
    }
</script>

<style>
</style>
