<template>
  <div class="container">
    <div class="row" :class="checkTerm" v-if="!editMode">
      <div class="col"><p>{{salesPerson.name}}</p></div>
      <div class="col"><p>{{salesPerson.manager}}</p></div>
      <div class="col">
        <div class="btn-group">
          <button class="btn btn-warning" @click="editMode = !editMode" type="button">Edit</button>
          <button class="btn btn-success" type="button" @click="addSale()" :disabled="isInvalidUser">Sale</button>
        </div>
      </div>
    </div>
    <div v-else class="row">
      <div class="col-4 mb-3">
        <input type="text" class="form-control" v-model="salesPersonAdd.name">
      </div>
      <div class="col-4 mb-3">
        <input type="text" class="form-control" v-model="salesPersonAdd.manager">
      </div>
      <div class="col-4 mb-3">
        <div class="btn-group">
          <button class="btn btn-primary" @click="saveData()" type="button">Save</button>
          <button class="btn btn-danger" @click="editMode = !editMode" type="button">Delete</button>
        </div>
      </div>
      <div class="col text-start">
        <label>Address</label>
        <input type="text" class="form-control" v-model="salesPersonAdd.address">
      </div>
      <div class="col text-start">
        <label>Phone</label>
        <input type="text" class="form-control" v-model="salesPersonAdd.phone">
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "SalesPerson",
  props: {
    salesPerson: {
      name: String,
      manager: String,
      phone: String,
      salesPersonId: Number,
      address: String,
      startDate: Date,
      endDate: Date
    },
    editModePar: Boolean
  },
  data: function () {
    return {
      editMode: this.editModePar,
      salesPersonAdd: {
        name: this.salesPerson.name,
        address: this.salesPerson.address,
        phone: this.salesPerson.phone,
        manager: this.salesPerson.manager
      }
    }
  },
  methods: {
    addSale: function(){
        this.$emit('saleEvent', this.salesPerson.salesPersonId)
    },
    saveData: function(){
      this.editMode = !this.editMode;

      let nameArr = this.splitName(this.salesPersonAdd.name);

      let payload = {
        salesPersonId: this.salesPerson.salesPersonId,
        firstName: nameArr[0],
        lastName: nameArr.length > 1 ? nameArr[nameArr.length - 1] : '',
        address: this.salesPersonAdd.address,
        phone: this.salesPersonAdd.phone,
        manager: this.salesPersonAdd.manager
      }

      axios({
        method: 'post',
        url: this.$hostname + 'salesperson/update',
        headers: {
          'Access-Control-Allow-Origin': '*',
          'Content-type': 'application/json'
        },
        data: JSON.stringify(payload)
      }).then(response => {
        alert(response.data.response)
        this.$emit('update', true)
      })
      .catch(err => {
        console.log(err);
        alert(err.response.data.response)

        this.salesPersonAdd = {
          name: this.salesPerson.name,
          address: this.salesPerson.address,
          phone: this.salesPerson.phone,
          manager: this.salesPerson.manager
        }
      })
    },
    splitName: function (val) {
      return val.split(' ');
    }
  },
  computed: {
    checkTerm: function(){
      if(this.salesPerson.endDate < Date.now || this.salesPerson.startDate > Date.now){
        return {
          'text-muted': true
        }
      } else{
        return {}
      }
    },
    isInvalidUser: function(){
      return this.salesPerson.endDate < Date.now || this.salesPerson.startDate > Date.now
    }
  }
}
</script>

<style scoped>

</style>