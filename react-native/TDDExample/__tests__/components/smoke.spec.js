import React from 'react';
import { Text } from 'react-native';
import { shallow } from 'enzyme';

// Example, no need to test react-native components by themselves
describe('Text', () => {
    it('renders text', () => {
        const wrapper = shallow(<Text>Hello, world!</Text>);
        expect(wrapper.text()).toEqual('Hello, world!');
    })
})