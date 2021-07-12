/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

import { exists, mapValues } from '../runtime';
import {
    ExecutionModel,
    ExecutionModelFromJSON,
    ExecutionModelFromJSONTyped,
    ExecutionModelToJSON,
} from './';

/**
 * 
 * @export
 * @interface CustomActionSettings
 */
export interface CustomActionSettings {
    /**
     * 
     * @type {ExecutionModel}
     * @memberof CustomActionSettings
     */
    beforeApprovalProcessExecution?: ExecutionModel | null;
    /**
     * 
     * @type {ExecutionModel}
     * @memberof CustomActionSettings
     */
    afterApprovalProcessExecution?: ExecutionModel | null;
    /**
     * 
     * @type {ExecutionModel}
     * @memberof CustomActionSettings
     */
    postExecution?: ExecutionModel | null;
    /**
     * 
     * @type {ExecutionModel}
     * @memberof CustomActionSettings
     */
    beforeSubmission?: ExecutionModel | null;
    /**
     * 
     * @type {ExecutionModel}
     * @memberof CustomActionSettings
     */
    whenErrorTaskGenerated?: ExecutionModel | null;
}

export function CustomActionSettingsFromJSON(json: any): CustomActionSettings {
    return CustomActionSettingsFromJSONTyped(json, false);
}

export function CustomActionSettingsFromJSONTyped(json: any, ignoreDiscriminator: boolean): CustomActionSettings {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'beforeApprovalProcessExecution': !exists(json, 'beforeApprovalProcessExecution') ? undefined : ExecutionModelFromJSON(json['beforeApprovalProcessExecution']),
        'afterApprovalProcessExecution': !exists(json, 'afterApprovalProcessExecution') ? undefined : ExecutionModelFromJSON(json['afterApprovalProcessExecution']),
        'postExecution': !exists(json, 'postExecution') ? undefined : ExecutionModelFromJSON(json['postExecution']),
        'beforeSubmission': !exists(json, 'beforeSubmission') ? undefined : ExecutionModelFromJSON(json['beforeSubmission']),
        'whenErrorTaskGenerated': !exists(json, 'whenErrorTaskGenerated') ? undefined : ExecutionModelFromJSON(json['whenErrorTaskGenerated']),
    };
}

export function CustomActionSettingsToJSON(value?: CustomActionSettings | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'beforeApprovalProcessExecution': ExecutionModelToJSON(value.beforeApprovalProcessExecution),
        'afterApprovalProcessExecution': ExecutionModelToJSON(value.afterApprovalProcessExecution),
        'postExecution': ExecutionModelToJSON(value.postExecution),
        'beforeSubmission': ExecutionModelToJSON(value.beforeSubmission),
        'whenErrorTaskGenerated': ExecutionModelToJSON(value.whenErrorTaskGenerated),
    };
}


