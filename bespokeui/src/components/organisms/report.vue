<template>
  <div class="container-fluid">
    <div class="row d-flex justify-content-center mb-3">
      <div class="col">
        <div class="form-group">
          <label>Quarter</label>
          <input class="form-control" type="number" max="4" min="1" v-model.number="qtr">
        </div>
      </div>
      <div class="col">
        <label>Year</label>
        <input class="form-control" type="number" :max="new Date().getFullYear()" :min="new Date().getFullYear() - 20" v-model.number="year">
      </div>
      <div class="col">
        <label>Sales Person</label>
        <select class="form-select" v-model="salespersonId">
          <option :value="null"></option>
          <option v-for="item in salesPeople" :key="item.index" :value="item.salesPersonId">{{item.name}}</option>
        </select>
      </div>
      <div class="col">
        <div class="btn-group">
          <button class="btn btn-primary btn-group" type="button" @click="getReport()">Go</button>
        </div>
      </div>
    </div>
    <div class="row">
      <report-results v-if="results.length > 0" :results="results"></report-results>
    </div>
  </div>
</template>

<script>
import axios from "axios";
import ReportResults from "@/components/atoms/reportResults";

export default {
  name: "report",
  components: {ReportResults},
  props: {
    salesPeople: Array
  },
  data: function(){
    return {
      qtr: 1,
      year: new Date().getFullYear(),
      salespersonId: null,
      results: []
    }
  },
  methods: {
    getReport: function (){
      axios({
        method: 'post',
        url: this.$hostname + 'reports',
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-type': 'application/json'
        },
        data: JSON.stringify({
          qtr: this.qtr,
          year: this.year,
          salespersonId: this.salespersonId
        })
      }).then(response => this.results = response.data)
      .catch(err => alert("something went wrong, please see console for details. " + err));
    }
  }
}
</script>

<style scoped>

</style>