import Vue from 'vue'
import App from './App.vue'
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap'


Vue.config.productionTip = false
Vue.prototype.$hostname = "https://localhost:5001/"

new Vue({
  render: h => h(App),
}).$mount('#app')
