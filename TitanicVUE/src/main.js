/*how to prepare develop envirement
 * We need to install  
 * Node.js
 * VUE CLI
 * Echarts
 */

import Vue from 'vue';
import App from './App.vue';

Vue.config.productionTip = true;

new Vue({
    render: h => h(App)
}).$mount('#app');
