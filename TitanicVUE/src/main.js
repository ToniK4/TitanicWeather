/*How to prepare develop env.? To install the following packages under folder /TitanicVUE
 * node.js
 * VUE Cli
 * echarts
 * bootstrap-vue

 * npm run build
 * npm run serve
  
 You will get the application to run. 
 */


import Vue from 'vue';
import App from './App.vue';
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import { BootstrapVue, IconsPlugin } from 'bootstrap-vue'

Vue.config.productionTip = false;
Vue.use(BootstrapVue)
Vue.use(IconsPlugin)

new Vue({
    render: h => h(App)
}).$mount('#app');

