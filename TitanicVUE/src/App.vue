<template>
    <div id="app">
        <div>
            <b-tabs content-class="mt-3" justified>
                <b-tab title="Welcome" active>
                    <b-container>
                        <b-row>
                            <b-col>
                                <b-row>
                                    <p> Home </p>
                                    <Gauge echartId="HomeHeating" echartColor="#fac858" echartUnit="Level" />
                                    <Gauge echartId="HomeTemperature" echartColor="#D03CDD" echartUnit="¡æ" />
                                    <Gauge echartId="HomeHumidity" echartColor="#27C7C7" echartUnit="%" />
                                </b-row>
                            </b-col>

                            <b-col>
                                <p>
                                    Today
                                </p>
                                <b-row>
                                    <Gauge echartId="OutTemperature" echartColor="#D03CDD" echartUnit="¡ãC" />
                                    <Gauge echartId="OutHumidity" echartColor="#27C7C7" echartUnit="%" />
                                    <Gauge echartId="Wind" echartColor="#ee6666" echartUnit="m/s" />
                                </b-row>
                            </b-col>
                        </b-row>
                    </b-container>
                </b-tab>
            </b-tabs>
        </div>
    </div>
</template>

<script>
    import Gauge from "./components/Gauge.vue";
    export default {
        name: "App",   
        components: {
            Gauge
        },
    };
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        text-align: center;
        color: #ffffff; 
        margin-top: 0px;
        background-color: #100C2A 
    }
</style>
