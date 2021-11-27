/*how to prepare develop envirement
 * We need to install  
 * Node.js
 * VUE CLI
 * Echarts
 * BootstrapVue
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
