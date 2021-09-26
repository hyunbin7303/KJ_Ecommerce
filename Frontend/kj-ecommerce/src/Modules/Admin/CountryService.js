export class CountryService {

    getCountries() {


        fetch('countries.json').then(res => console.log('res',res))


        return fetch('countries.json').then(res => res.json())
            .then(d => d.data);
    }
}